using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaGUI
{
    class aranynemzet
    {
        readonly string nemzet1;
        public string Nemzet1 => nemzet1;

        public aranynemzet(string nemzet1)
        {
            this.nemzet1 = nemzet1;
        }
        public override string ToString()
        {
            return nemzet1;
        }
    }
}
