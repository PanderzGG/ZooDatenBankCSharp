using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Tier
    {
        private int tierID;
        private string name;
        private string gehegename;
        private int gehegeID;
        private int themenbereichID;
        private int tierartID;

        public int TierID { get => tierID; set => tierID = value; }
        public string Name { get => name; set => name = value; }
        public int GehegeID { get => gehegeID; set => gehegeID = value; }
        public int TierartID { get => tierartID; set => tierartID = value; }
        public int ThemenbereichID { get => themenbereichID; set => themenbereichID = value; }
        public string Gehegename { get => gehegename; set => gehegename = value; }

        public Tier(int tierID, string name, int gehegeID, int tierartID)
        {
            this.tierID = tierID;
            this.name = name;
            this.gehegeID = gehegeID;
            this.tierartID = tierartID;
        }

        public Tier(string gehegename, string name)
        {
            this.gehegename = gehegename;
            this.name = name;
        }

    }
}