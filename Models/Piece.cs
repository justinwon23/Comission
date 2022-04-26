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
        [Display(Name = "Materials")]
        public string Materials { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        [Display(Name = "Size")]
        public string Size { get; set; }

        // We can add more here or change as needed.

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Relationships:

        public int UserId { get; set; }

        public User PieceCreator { get; set; }
        public User PieceComissioner { get; set; }
    }
}