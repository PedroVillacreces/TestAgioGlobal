namespace TestAgioGlobalModel.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Airports
    {
        [Key]
        public int AirportId { get; set; }
        [Required]
        [MaxLength(150)]
        public string AirtportName { get; set; }

        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
    }
}
