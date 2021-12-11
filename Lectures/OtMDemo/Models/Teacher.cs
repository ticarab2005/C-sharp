using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OtMDemo.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId {get;set;}
        public string Name {get;set;}
        public string Course {get;set;}
        // We get to setup a list of students
        public List<Student> MyStudents {get;set;}
        public DateTime CreatedAt  {get;set;} = DateTime.Now;
        public DateTime UpdatedAt  {get;set;} = DateTime.Now;
    }
}