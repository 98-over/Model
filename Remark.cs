using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Remark
    {
        private string r_no;
        private string r_text;
        private DateTime r_time;
        private string u_remark;
        private string  u_deremark;
        private string  b_no;

        public string R_no { get => r_no; set => r_no = value; }
        public string R_text { get => r_text; set => r_text = value; }
        public DateTime R_time { get => r_time; set => r_time = value; }
        public string U_remark { get => u_remark; set => u_remark = value; }
        public string U_deremark { get => u_deremark; set => u_deremark = value; }
        public string  B_no { get => b_no; set => b_no = value; }

    }
}
