using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }

        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String AuthorName { set; get; }
       
        public DateTime AuthorDOB { set; get; }
   
        public int Numberofbook { set; get; }
        public String AuthorRoyalty { set; get; }
        
    }
}
