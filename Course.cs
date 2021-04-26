using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Introduce { get; set; }
        public string CourseType { get; set; }
        public int UploaderId { get; set; }
        public string Coursepic { get; set; }

    }
}