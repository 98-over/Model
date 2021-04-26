using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model { 
    public class FileModle
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime Time { get; set; }
        public int UploadId { get; set; }
        public string CourseID { get; set; }
        public string Size { get; set; }
    }
}