using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Comission.Models
{
    public class Piece
    {

        [Key]
        public int PieceId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        [Display(Name = "Art Piece Name")]
        public string PieceName { get; set; }
        
        //Color Attributes
        public bool Dark { get; set; }
        public bool Light { get; set; }
        public bool Colorful { get; set; }
        public string ImgURL { get; set; }

        //Style Attributes
        public bool Modern { get; set; }
        public bool Cubic { get; set; }
        public bool Abstract { get; set; }
        public bool Impressionist { get; set; }

        //Material Attributes
        public bool Watercolor { get; set; }
        public bool OilBased { get; set; }
        public bool Latex { get; set; }
        public bool Enamel { get; set; }

        // We can add more here or change as needed.

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Relationships:
        //One to Many: An artpiece has a creator who is a User.
        public int CreatorId { get; set; }
        public User PieceCreator { get; set; }
    }
}