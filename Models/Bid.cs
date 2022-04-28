using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comission.Models
{
    public class Bid
    {
        [Key]

        public int BidId {get; set;}

        [Required(ErrorMessage = "is required")]
        public string Description {get; set;}

        [Required]
        public int Price {get; set;}

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Deadline {get; set;}

        [Required(ErrorMessage = "is required")]
        public int BuyerId {get; set;}
        [ForeignKey("BuyerId")]
        [InverseProperty("BuyerBids")]

        public virtual User Buyer {get; set;}


        public int ArtistId {get; set;}

        [ForeignKey("ArtistId")]
        [InverseProperty("ArtistBids")]
        public virtual User Artist {get; set;}
    }
}