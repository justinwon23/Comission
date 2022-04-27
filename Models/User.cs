using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Comission.Models
{
    
    public class User
    {
        private ComissionContext db;
        
        [Key]
        public int UserId {get; set;}

        [Required(ErrorMessage ="is required")]
        [MinLength(2, ErrorMessage ="Must be at least 2 characters")]
        [Display(Name ="First Name")]
        public string FirstName {get; set;}
        
        [Required(ErrorMessage ="is required")]
        [MinLength(2, ErrorMessage ="Must be at least 2 characters")]
        [Display(Name ="Last Name")]
        public string LastName {get; set;}

        [Required(ErrorMessage ="is required")]
        [MinLength(2, ErrorMessage ="Must be at least 2 characters")]
        [Display(Name ="Username")]
        public string Username {get; set;}

        [Required(ErrorMessage ="is required")]
        [EmailAddress]
        public string Email {get; set;}

        [Required(ErrorMessage ="is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Must be at least 8 characters")]
        public string Password {get; set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        public string Confirm {get; set;}

        [Display(Name ="Sign up as a creator?")]
        public bool isArtist{get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<UserArtConnection> UserHasArt {get; set;}

        
        
        
        
        public float CalculateStyleRatio(int totalPieces, int TotalPieceAttributes)
        {
            
            Console.WriteLine("Calculate");
            Console.WriteLine(totalPieces);
            Console.WriteLine(TotalPieceAttributes);
            float ratio = (float)TotalPieceAttributes/(float)totalPieces;
            Console.WriteLine("Ratio");
            Console.WriteLine(ratio);

            
            return ratio;
        }


        public int GetDarkCount(User loggedInUser)
        {
            int count = 0;
            foreach(var connection in loggedInUser.UserHasArt)
            {
                if(connection.Piece.Dark == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetLightCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Light == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetColorfulCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Colorful == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetModernCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Modern == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetCubicCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Cubic == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetAbstractCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Abstract == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetImpressionistCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Impressionist == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetWaterColorCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Watercolor == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetOilBasedCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.OilBased == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetLatexCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Latex == true)
                {
                    count++;
                }  
            }
            return count;
        }
        public int GetEnamelCount(User loggedInUser)
        {
            int count = 0;
            foreach(UserArtConnection relationship in loggedInUser.UserHasArt)
            {
                if(relationship.Piece.Enamel == true)
                {
                    count++;
                }  
            }
            return count;
        }



        public Dictionary<string, float> StyleOverView(User loggedInUser)
        {
            IDictionary<string, float> OverView = new Dictionary<string, float>();

            int totalPieces = loggedInUser.UserHasArt.Count;

            int darkCount = GetDarkCount(loggedInUser);

            Console.WriteLine("=========================================");
            Console.WriteLine(darkCount);
            Console.WriteLine("=========================================");
            Console.WriteLine(totalPieces);

            float darkValue = CalculateStyleRatio(totalPieces, GetDarkCount(loggedInUser));
            Console.WriteLine("=========================================");
            Console.WriteLine(darkValue);

            int lightCount = GetLightCount(loggedInUser);
            float lightValue = CalculateStyleRatio(totalPieces, GetLightCount(loggedInUser));

            int colorfulCount = GetColorfulCount(loggedInUser);
            float colorfulValue = CalculateStyleRatio(totalPieces, GetColorfulCount(loggedInUser));

            int modernCount = GetModernCount(loggedInUser);
            float modernValue = CalculateStyleRatio(totalPieces, GetModernCount(loggedInUser));

            int cubicCount = GetCubicCount(loggedInUser);
            float cubicValue = CalculateStyleRatio(totalPieces, GetCubicCount(loggedInUser));

            int abtractCount = GetAbstractCount(loggedInUser);
            float abstractValue = CalculateStyleRatio(totalPieces, GetAbstractCount(loggedInUser));

            int impressionistCount = GetImpressionistCount(loggedInUser);
            float impressionistValue = CalculateStyleRatio(totalPieces, GetImpressionistCount(loggedInUser));

            int waterColorCount = GetWaterColorCount(loggedInUser);
            float waterColorValue = CalculateStyleRatio(totalPieces, GetWaterColorCount(loggedInUser));

            int oilBasedCount = GetOilBasedCount(loggedInUser);
            float oilBasedValue = CalculateStyleRatio(totalPieces, GetOilBasedCount(loggedInUser));

            int latexCount = GetLatexCount(loggedInUser);
            float latexValue = CalculateStyleRatio(totalPieces, GetLatexCount(loggedInUser));

            int enamelCount = GetEnamelCount(loggedInUser);
            float enamelValue = CalculateStyleRatio(totalPieces, GetEnamelCount(loggedInUser));

            OverView.Add(new KeyValuePair<string, float>("DarkValue", darkValue));
            OverView.Add(new KeyValuePair<string, float>("LightValue", lightValue));
            OverView.Add(new KeyValuePair<string, float>("ColorfulValue", colorfulValue));
            OverView.Add(new KeyValuePair<string, float>("ModernValue", modernValue));
            OverView.Add(new KeyValuePair<string, float>("CubicValue", cubicValue));
            OverView.Add(new KeyValuePair<string, float>("AbstractValue", abstractValue));
            OverView.Add(new KeyValuePair<string, float>("ImpressionistValue", impressionistValue));
            OverView.Add(new KeyValuePair<string, float>("WaterColorValue", waterColorValue));
            OverView.Add(new KeyValuePair<string, float>("OilBasedValue", oilBasedValue));
            OverView.Add(new KeyValuePair<string, float>("LatexValue", latexValue));
            OverView.Add(new KeyValuePair<string, float>("EnamelValue", enamelValue));
            

            return (Dictionary<string, float>)OverView;

        }
    }
}