using System.ComponentModel.DataAnnotations;

namespace SpringBootApp.Models
{
    public class LicencePlate
    {
        public int Id { get; set; }

        //[RegularExpression(@"[A-Z]+[0-9]-*$")]
        [MaxLength(7, ErrorMessage = "Sorry, the submitted licence plate is not valid")]
        public string Plate { get; set; }

        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}