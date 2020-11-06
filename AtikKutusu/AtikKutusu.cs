using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AtikKutusuUygulama
{
    class AtikKutusu:IAtikKutusu
    {
        public double Kapasite { get; set; }
        public double DoluHacim { get; set; }
        public double DolulukOrani { get; set; }
        public int BosaltmaPuani { get; set; }

        public bool Ekle(Atik atik)
        {
            bool eklenebilir = false;
            DoluHacim += atik.Hacim;
            if (Kapasite > DoluHacim)
            {
                eklenebilir = true;
            }

            return eklenebilir;
        }

        public bool Bosalt()
        {
            bool bosalt = false;
            DolulukOrani = DoluHacim/Kapasite;
            if (DolulukOrani >= 0.75)
            {
                bosalt = true;
            }

            DoluHacim = 0;
            return bosalt;
        }
    }
}
