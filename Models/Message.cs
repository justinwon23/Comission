using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Comission.Models
{
    public class Message
    {
        [Key]

        public int MessageId {get; set;}

        [Required(ErrorMessage = "is required")]
        public string Content {get; set;}

        [Required(ErrorMessage = "is required")]
        public int SenderId {get; set;}
        [ForeignKey("SenderId")]
        [InverseProperty("SenderMessages")]

        public virtual User Sender {get; set;}

        [Required(ErrorMessage = "is required")]

        public int ReceiverId {get; set;}

        [ForeignKey("ReceiverId")]
        [InverseProperty("ReceiverMessages")]
        public virtual User Receiver {get; set;}
    }
}