using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BComp_Authorization
    {
        BComp_AverageDTW compare = null;
        BComp_AverageDTW toTheOrignin = null;
        int[,] comp=null;
        int[,] orig = null;

        public BComp_Authorization(String Fname)
        {
            compare = new BComp_AverageDTW(Fname);
            comp=compare.AverageDTW(1,10);

            toTheOrignin = new BComp_AverageDTW(Fname);
            orig=toTheOrignin.AverageDTW(1, 20);
        }

        public String Autho()
        {
            String x, y;
            if (comp[0,0]<orig[0,0]) x="x.Original"; else x="x.Froged";
            if (comp[0, 1] < orig[0, 1]) y = "y.Original"; else y = "y.Froged";
            return x+y;
        }
    }
}