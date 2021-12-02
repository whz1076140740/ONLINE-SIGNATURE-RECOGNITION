using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BComp_Verifier
    {
        String selectedFname;
        int uid;

        int[,] comp;
        int[,] referenced;
        bool[] XYisForged = new bool[2] { false,false};
        public String XYprintResult;

        public BComp_Verifier(String selectedFname)
        {
            this.selectedFname = selectedFname;
            this.uid = int.Parse(selectedFname.Split('S')[0].Split('U')[1]);
        }
        public void verify()
        {
            referenced= referencedDTW_Avg();
            comp = selectedDTW_Avg();
            XYisForged = verifyIsForged_XY();
            XYprintResult = printVerifyResult_XY();
        }

        public String printVerifyResult_XY()
        {
            String XY;
            if (comp[0, 0] <= referenced[0, 0]) XY = "X is Genuine"; else XY = "X is Forged";
            XY += " , ";
            if (comp[0, 1] <= referenced[0, 1]) XY += "Y is Genuine"; else XY += "Y is Forged";

            return XY;
        }
        public bool[] verifyIsForged_XY()
        {
            if (comp[0, 0] <= referenced[0, 0]) XYisForged[0] = false; else XYisForged[0] = true;
            if (comp[0, 1] <= referenced[0, 1]) XYisForged[1] = false; else XYisForged[1] = true;
            return XYisForged;
        }


        private int[,] referencedDTW_Avg()
        {
            int[,] referencedAvg = new int[1, 2] { { 0,0} };
            for (int i =1; i<= 40; i++)
            {
                String singlePairOfReferencedFname = "U" + uid + "S" + i+".TXT";
                BComp_AverageDTW avg = new BComp_AverageDTW(singlePairOfReferencedFname, selectedFname);
                int[,] singlePairOfReferencedDTW_Avg = avg.AverageDTW(1, 10);

                referencedAvg[0, 0] += singlePairOfReferencedDTW_Avg[0, 0];
                referencedAvg[0, 1] += singlePairOfReferencedDTW_Avg[0, 1];
            }

            referencedAvg[0, 0] /= 40;
            referencedAvg[0, 1] /= 40;
            return referencedAvg;
        }
        private int[,] selectedDTW_Avg()
        {
            int[,] selectedAvg;
            BComp_AverageDTW avg = new BComp_AverageDTW(selectedFname, selectedFname);
            selectedAvg=  avg.AverageDTW(1,10);
            return selectedAvg;
        }

    }
}