using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Gehege
    {
        private int gehegeID;
        private string name;
        private int themenbereichID;

        public int GehegeID { get => gehegeID; set => gehegeID = value; }
        public string Name { get => name; set => name = value; }
        public int ThemenbereichID { get => themenbereichID; set => themenbereichID = value; }

        public Gehege(int gehegeID, string name, int themenbereichID)
        {
            this.gehegeID = gehegeID;
            this.name = name;
            this.themenbereichID = themenbereichID;
        }

        
    }
}