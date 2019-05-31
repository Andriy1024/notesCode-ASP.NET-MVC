using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace notesCode_ASP_NET_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Filepath { get; set; }
    }
}