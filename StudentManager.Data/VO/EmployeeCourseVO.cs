using System;

namespace StudentManager.Data.VO
{
    public class EmployeeCourseVO
    {
        // Employee
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpContact { get; set; }
        public string Position { get; set; }
        public int Authority { get; set; }
        public DateTime EmpStartDate { get; set; }
        public DateTime EmpEndDate { get; set; }
        public byte[] Image { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SpecialNote { get; set; }

        // Course
        public int CourseNo { get; set; }
        public string CourseName { get; set; }
        public int Payment { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
    }
}
