using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Comission.Models
{
    public class Taste
    {
        [Key]
        public int TasteId { get; set; }
        public User UsersTaste { get; set; }
        public int UserId { get; set; }

        //Color Attributes
        public int Dark { get; set; }
        public int Light { get; set; }
        public int Colorful { get; set; }

        //Style Attributes
        public int Modern { get; set; }
        public int Cubic { get; set; }
        public int Abstract { get; set; }
        public int Impressionist { get; set; }

        //Material Attributes
        public int Watercolor { get; set; }
        public int OilBased { get; set; }
        public int Latex { get; set; }
        public int Enamel { get; set; }
    }
}