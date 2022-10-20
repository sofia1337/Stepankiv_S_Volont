using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stepankiv_S_Volont.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name of event")]
        public string NameEvent { get; set; }

        [DisplayName("Count of view")]
        public int Display { get; set; }

        [DisplayName("Goal")]
        [Range(1,1000000)]
        public decimal Price { get; set; }

        [DisplayName("Deadline")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}