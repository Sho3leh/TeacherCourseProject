﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherCourseProject.Models
{
    public class StudentCourse
    {
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
