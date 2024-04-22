using System.ComponentModel.DataAnnotations;

namespace TechCareerNetCoreWebApi.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FilmAdi { get; set; }

        [Required]
        public double Süresi { get; set; }

        [Required]
        public string YayinlanmaTarihi { get; set; }
    }
}
