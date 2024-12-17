using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Themenbereiche
    {
        private int TNr;
        private string TName;

        public int TNr1 { get => TNr; set => TNr = value; }
        public string TName1 { get => TName; set => TName = value; }

        public Themenbereiche(int TNr, string TName)
        {
            this.TNr = TNr;
            this.TName = TName;
        }
    }
}