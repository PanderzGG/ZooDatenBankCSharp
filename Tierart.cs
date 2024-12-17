using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Tierart
    {
        private int tierartId;
        private string name;

        public int TierartId { get => tierartId; set => tierartId = value; }
        public string Name { get => name; set => name = value; }

        public Tierart(int tierartId, string name)
        {
            this.tierartId = tierartId;
            this.name = name;
        }
    }
}