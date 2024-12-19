using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class fuetterung
    {
        private int futterID;
        private int tierID;
        private string uhrzeit;
        private int menge;

        public int FutterID { get => futterID; set => futterID = value; }
        public int TierID { get => tierID; set => tierID = value; }
        public string Uhrzeit { get => uhrzeit; set => uhrzeit = value; }
        public int Menge { get => menge; set => menge = value; }

        public fuetterung(int futterID, int tierID, string uhrzeit, int menge)
        {
            this.futterID = futterID;
            this.tierID = tierID;
            this.uhrzeit = uhrzeit;
            this.menge = menge;
        }
    }
}
