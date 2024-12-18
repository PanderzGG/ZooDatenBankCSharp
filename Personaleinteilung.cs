using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Personaleinteilung
    {
        private int einteilungsID;
        private int hauptpfleger;
        private int normalpfleger;
        private int fk_gehegeID;
        private int fk_personalID;

        public int EinteilungsID { get => einteilungsID; set => einteilungsID = value; }
        public int Fk_gehegeID { get => fk_gehegeID; set => fk_gehegeID = value; }
        public int Fk_personalID { get => fk_personalID; set => fk_personalID = value; }
        public int Hauptpfleger { get => hauptpfleger; set => hauptpfleger = value; }
        public int Normalpfleger { get => normalpfleger; set => normalpfleger = value; }

        public Personaleinteilung(int einteilungsID, int hauptpfleger, int normalpfleger, int fk_gehegeID, int fk_personalID)
        {
            this.einteilungsID = einteilungsID;
            this.hauptpfleger = hauptpfleger;
            this.normalpfleger = normalpfleger;
            this.fk_gehegeID = fk_gehegeID;
            this.fk_personalID = fk_personalID;
        }
    }
}
