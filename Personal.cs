using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenBankZoo
{
    public class Personal
    {
            private int personalID;
            private string name;

        public int PersonalID { get => personalID; set => personalID = value; }
        public string Name { get => name; set => name = value; }

        public Personal(int personalID, string name)
        {
            this.personalID = personalID;
            this.name = name;
        }

    }
}
