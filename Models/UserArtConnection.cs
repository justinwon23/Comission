using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Comission.Models
{
    public class UserArtConnection
    {
        
        [Key]
        public int UserArtConnectionId { get; set; }

        public int UserId { get; set; }

        public int PieceId { get; set; }

        public User User { get; set; }

        public Piece Piece { get; set; }
        


    }
}