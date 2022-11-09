using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaGUI
{
    class versenyszamok
    {
        readonly string versenyszamok1;
        public string Versenyszamok1 => versenyszamok1;

        public versenyszamok(string versenyszamok1)
        {
            this.versenyszamok1 = versenyszamok1;
        }
        public override string ToString()
        {
            return versenyszamok1;
        }
    }
}
