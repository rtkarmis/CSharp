using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtikKutusuUygulama
{
    class Atik:IAtik
    {
        public double Hacim { get; set; }
        public Image Image { get; set; }
        public Tur Tur { get; set; }
        public string Ad { get; set; }
    }

    enum Tur
    {
        Organik,
        Cam,
        Kagit,
        Metal
    }
}
