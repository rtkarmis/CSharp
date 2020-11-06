using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtikKutusuUygulama
{
    interface IDolabilen
    {
        double Kapasite { get; set; }
        double DoluHacim { get; }
        double DolulukOrani { get; }
    }
}
