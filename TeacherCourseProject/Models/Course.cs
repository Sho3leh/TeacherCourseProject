using System.Collections.Generic;

namespace TeacherCourseProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
