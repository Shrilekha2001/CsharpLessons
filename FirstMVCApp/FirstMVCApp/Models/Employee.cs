using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Employee
    {
        public int eno { get; set; }
        [Required]
        [MinLength(3,ErrorMessage ="Name must should be between 3 and 28 char")]
        public String Name { get; set; }=string.Empty;
        public decimal salary { get; set; }

       public string City { get; set; }



    }
}
