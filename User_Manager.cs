using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User_Manager
    {
        private string ManId;
        private string ManName;
        private string ManSex;
        private string ManAge;
        private string ManPhotoUrl;

        public string ManId1 { get => ManId; set => ManId = value; }
        public string ManName1 { get => ManName; set => ManName = value; }
        public string ManSex1 { get => ManSex; set => ManSex = value; }
        public string ManAge1 { get => ManAge; set => ManAge = value; }
        public string ManPhotoUrl1 { get => ManPhotoUrl; set => ManPhotoUrl = value; }
    }
}
