using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blog
    {
        private string b_no;
        private string b_text;
        private DateTime b_time;
        private string b_img;
        private string u_id;

        public string B_no { get => b_no; set => b_no = value; }
        public string B_text { get => b_text; set => b_text = value; }
        public DateTime B_time { get => b_time; set => b_time = value; }
        public string B_img { get => b_img; set => b_img = value; }
        public string U_id { get => u_id; set => u_id = value; }
    }
}
