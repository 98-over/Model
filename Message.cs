using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Message
{
        private string sendId;
        private string recvId;
        private string meg;
        private DateTime time;
        private int megType;

        public string SendId { get => sendId; set => sendId = value; }
        public string RecvId { get => recvId; set => recvId = value; }
        public string Meg { get => meg; set => meg = value; }
        public DateTime Time { get => time; set => time = value; }
        public int MegType { get => megType; set => megType = value; }
    }
}
