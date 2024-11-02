using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherCourseProject.Models
{
    public class TeacherCourse
    {
        [Key, Column(Order = 0)]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
