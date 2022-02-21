using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsApp.Models
{
    public class ManageProducts
    {
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string? Code { get; set; }

        [StringLength(60, MinimumLength = 3)][Required]
        public string? Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }

    public class TechnicianManager
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Technician Name")]
        public string? TechnicianName { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Technician Email")]
        public string? TechnicianEmail { get; set; }

        [/*RegularExpression("[0-9]"),*/ StringLength(10)]
        [Display(Name = "Technician Phone")]
        public int TechnicianPhone { get; set; }
    }

    public class CustomerManager
    {
        public int? Id { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerState { get; set; }
        public string? CustomerPostal { get; set; }
        public string? CustomerCountry { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string? CustomerEmail { get; set; }

        /*[RegularExpression("[0-9]"), StringLength(10)]*/
        public int? CustomerPhone { get; set; }
    }

    public class IncidentPage
    {
        public string? Id { get; set; } 
        public string? Product { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Technician { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOpened { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }
    }
}
