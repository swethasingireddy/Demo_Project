using System.ComponentModel.DataAnnotations;

namespace CourseFeedback.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Course { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }

        public string Semester { get; set; }

        public string Instructor { get; set; }

        public bool IsAnonymous { get; set; }
    }
}