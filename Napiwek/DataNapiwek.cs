using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napiwek
{
    public class DataNapiwek
    {
        public double wartoscnapiwku { get; set; }
        public double procent { get; set; }

        public double obliczprocnet(double kwota, double procent)
        {
            double wartoscnapiwku = 0;
            double wartoscprocentu = kwota * procent;
            wartoscnapiwku = Math.Round(kwota + wartoscprocentu,0);
            //wartoscnapiwku = Math.Round(wartoscnapiwku, 2);
            return wartoscnapiwku;
        }


    }
}
