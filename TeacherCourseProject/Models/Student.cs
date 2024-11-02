using System.Collections.Generic;

namespace TeacherCourseProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public bool IsDeleted { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
