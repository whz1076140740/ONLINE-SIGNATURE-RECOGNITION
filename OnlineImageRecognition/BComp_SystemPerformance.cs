using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BComp_SystemPerformance
    {
        private int uid = 0;
        private int testUid = 0;
        private int forgedTotalNum = 10;
        private int origianlTotalNum = 10;

        public BComp_SystemPerformance(int uid, int testuid, int forgedTotalNum = 10, int originalTotalNum = 10)
        {
            this.uid = uid;
            this.testUid = testuid;

            if (forgedTotalNum > 40) forgedTotalNum = 10;
            if (origianlTotalNum > 10) origianlTotalNum = 10;
        }

        public double[] performaceTestCalculation()
        {
            double[] performanceIndexXY = { -1, -1 };
            double[] forgedCountXY = forgedPerformanceCount(forgedTotalNum);
            double[] originalCountXY = originalPerformanceCount(origianlTotalNum);
            performanceIndexXY[0] = (forgedCountXY[0]+originalCountXY[0]) / 2 /forgedTotalNum;
            performanceIndexXY[1] = (forgedCountXY[1] + originalCountXY[1]) / 2 /origianlTotalNum;
            return performanceIndexXY;
        }



        private String parseToFileName(int uid, int sid)
        {
            return "U" + uid + "S" + sid+".TXT";
        }


        //forgedTest
        private double[] forgedPerformanceCount(int pickedFileNumber)
        {
            double[] countXY = { 0, 0 };
            for (int i = 1; i <= pickedFileNumber; i++)
            {
                String selectedFname = parseToFileName(this.testUid, i);
                String referencedFname = parseToFileName(this.uid, 1);

                //test
                Console.WriteLine("foredCheck:"+referencedFname+"\t"+selectedFname);

                int[] XY = AuthorizationXY(selectedFname,referencedFname);
                if(XY[0]==0) countXY[0] += 1;
                if (XY[1] == 0) countXY[1] += 1;
            }
            return countXY;
        }

        //originalTest
        private double[] originalPerformanceCount(int pickedFileNumber)
        {
            double[] countXY = {0,0};
            for (int i = 1; i <= pickedFileNumber; i++)
            {
                String selectedFname = parseToFileName(this.uid, i);
                String referencedFname = parseToFileName(this.uid, 1);

                //test
                Console.WriteLine("originalCheck:" + referencedFname + "\t" + selectedFname);

                int[] XY= AuthorizationXY( selectedFname, referencedFname);
                countXY[0] += XY[0];
                countXY[1] += XY[1];
            }
            return countXY;
        }

        //authorization for each file
        private int[] AuthorizationXY( String seletedFile, String referenFile)
        {
            int[] count = new int[2] {0,0};
            BComp_Authorization autho = new BComp_Authorization(seletedFile,referenFile);
            bool[] countXY = autho.xyIsForged();
            if (countXY[0] == false)  count[0] = 1;

            if (countXY[1] == false) count[1] = 1;
            return count;
        }
    }
}
