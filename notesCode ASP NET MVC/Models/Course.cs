using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace notesCode_ASP_NET_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Lesson> Lessons { get; set; }
    }

    public class Lesson
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Filepath { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}