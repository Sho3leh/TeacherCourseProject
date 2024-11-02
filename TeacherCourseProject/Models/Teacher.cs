using System.Collections.Generic;

namespace TeacherCourseProject.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
