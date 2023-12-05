using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiForSignUp.Models
{
    
    public class User
    {
        [Key]
        public int Uid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        //[Range(1,15)]
        public int AdharCard { get; set; }
        [Required]
        public string PanCard { get; set; }
       // [Required]
       // [DisplayFormat(DataFormatString ="{0:MM.DD.YYYY}")]
        public string DOB {  get; set; }
        [Required]

        public string MobileNumber { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string UImage { get; set; }
    }
}
