using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace FirstMVCEFApp.Models
{
    public class Appoinment
    {
        [Key]
        [Column("appoinmentno")]
        public string Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public string DoctorId { get; set; }
        [Required]
        public DateTime DOA { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
