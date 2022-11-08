using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data;

namespace atletikaGUI
{
    class vberedmenyek
    {
        readonly string nemzet;
        readonly string versenyzonev;
        readonly int nemzetkod;
        readonly string versenyszam;
        readonly string eredmeny;
        readonly int helyzes;

        public string Nemzet => nemzet;

        public string Versenyzonev => versenyzonev;

        public int Nemzetkod => nemzetkod;

        public string Versenyszam => versenyszam;

        public string Eredmeny => eredmeny;

        public int Helyzes => helyzes;

        public vberedmenyek(string nemzet, string versenyzonev, int nemzetkod, string versenyszam, string eredmeny, int helyzes)
        {
            this.nemzet = nemzet;
            this.versenyzonev = versenyzonev;
            this.nemzetkod = nemzetkod;
            this.versenyszam = versenyszam;
            this.eredmeny = eredmeny;
            this.helyzes = helyzes;
        }
       
    }
}
