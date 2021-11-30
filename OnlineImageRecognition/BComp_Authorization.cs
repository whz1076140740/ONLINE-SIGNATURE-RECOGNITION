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

        public BComp_Authorization(String Fname_Other,String Fname)
        {
            //compare with referenced 10 signature dtw
            compare = new BComp_AverageDTW(Fname_Other,Fname);
            comp=compare.AverageDTW(1,10);

            toTheOrignin = new BComp_AverageDTW(Fname, Fname);
            orig=toTheOrignin.AverageDTW(1, 20);
        }

        public String Autho()
        {
            String x, y;
            if (comp[0, 0] <= orig[0, 0]) x="x.Original"; else x="x.Froged";
            if (comp[0, 1] <= orig[0, 1]) y = "y.Original"; else y = "y.Froged";
            return x+" , "+y;
        }

        public bool[] xyIsForged()
        {
            bool[] isForged = {false,false};
            if (comp[0, 0] <= orig[0, 0]) isForged[0] = false; else isForged[0] = true;
            if (comp[0, 1] <= orig[0, 1]) isForged[1] = false; else isForged[1] = true;

            //test
            Console.Write("   "+Autho());
            Console.WriteLine();


            return isForged;
        }

      /*  public String referencedFileName()
        {

        }

        public String comparedFileName()
        {

        }*/
    }
}