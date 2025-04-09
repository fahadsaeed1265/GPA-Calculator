using System.ComponentModel.DataAnnotations;

namespace UE_GPA.Models
{
    public class StudentMark
    {
        public int Id { get; set; }
        public string StudentName { get; set; }


        [Required]
        public string Subject1 { get; set; }

        [Required]
        public int Marks1 { get; set; }

        [Required]
        public string Subject2 { get; set; }

        [Required]
        public int Marks2 { get; set; }

        [Required]
        public string Subject3 { get; set; }

        [Required]
        public int Marks3 { get; set; }

        [Required]
        public string Subject4 { get; set; }

        [Required]
        public int Marks4 { get; set; }

        [Required]
        public string Subject5 { get; set; }

        [Required]
        public int Marks5 { get; set; }

        public float GPA { get; set; }
    }
}
