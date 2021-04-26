using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reply
    {
        private string rp_no;
        private string r_no;
        private string send_id;
        private string recv_id;
        private string rp_text;
        private DateTime rp_time;

        public string Rp_no { get => rp_no; set => rp_no = value; }
        public string Send_id { get => send_id; set => send_id = value; }
        public string Recv_id { get => recv_id; set => recv_id = value; }
        public string Rp_text { get => rp_text; set => rp_text = value; }
        public DateTime Rp_time { get => rp_time; set => rp_time = value; }
        public string R_no { get => r_no; set => r_no = value; }
    }
}
