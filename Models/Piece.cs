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
        
        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        [Display(Name = "Image URL")]
        public string ImgURL { get; set; }
        
        //Color Attributes
        [Display(Name = "Dark")]
        public bool Dark { get; set; }
        [Display(Name = "Light")]
        public bool Light { get; set; }
        [Display(Name = "Colorful")]
        public bool Colorful { get; set; }

        //Style Attributes
        [Display(Name = "Modern")]
        public bool Modern { get; set; }
        [Display(Name = "Cubic")]
        public bool Cubic { get; set; }
        [Display(Name = "Abstract")]
        public bool Abstract { get; set; }
        [Display(Name = "Impressionist")]
        public bool Impressionist { get; set; }

        //Material Attributes
        [Display(Name = "Watercolor")]
        public bool Watercolor { get; set; }
        [Display(Name = "OilBased")]
        public bool OilBased { get; set; }
        [Display(Name = "Latex")]
        public bool Latex { get; set; }
        [Display(Name = "Enamel")]
        public bool Enamel { get; set; }

        // We can add more here or change as needed.

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Relationships:
        //One to Many: An artpiece has a creator who is a User.
        public List<UserArtConnection> ArtHasUsers { get; set; }
    }
}