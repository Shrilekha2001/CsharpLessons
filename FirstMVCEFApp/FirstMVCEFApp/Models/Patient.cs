using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCEFApp.Models
{
    public class Patient
    {
        [Key]
        [Column("Patientno")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20 chars")]
        public string Name { get; set; }=string.Empty;  
        public string City { get; set; } = string.Empty;
        public DateTime DOB { get; set; }

    }
}
