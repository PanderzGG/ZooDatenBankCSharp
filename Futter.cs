using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Futter
    {
        private int futterID;
        private string futterBezeichnung;
        private string futterEinheit;

        public int FutterID { get => futterID; set => futterID = value; }
        public string FutterBezeichnung { get => futterBezeichnung; set => futterBezeichnung = value; }
        public string FutterEinheit { get => futterEinheit; set => futterEinheit = value; }

        public Futter(int futterID, string futterBezeichnung, string futterEinheit)
        {
            this.futterID = futterID;
            this.futterBezeichnung = futterBezeichnung;
            this.futterEinheit = futterEinheit;
        }

        
    }
}
