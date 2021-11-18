using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BComp_AverageDTW
    {
        private const String DefaultPath = @"././././Task2/";
        private const String ReadType = @".TXT";
        private String SelectFileName;
        private int userID;
        private int[,] DTW;
        
        public BComp_AverageDTW(String FName)
        {
            SelectFileName = FName;
            userID = int.Parse(SelectFileName.Split('S')[0].Split('U')[1]);
        }




        public int[,] AverageDTW(int startSin, int endSin)
        {
           int[,] DTWaverage= Read(startSin,endSin);
            DTWaverage[0, 0] /= (endSin - startSin+1);
            DTWaverage[0, 1] /= (endSin - startSin+1);
            return DTWaverage;
        }

        
        public int[,] Read(int startSin, int endSin)
        {
            DBReader selectedFile = new DBReader();
            selectedFile.Read(DefaultPath + SelectFileName);

            List<DBReader> Averages = new List<DBReader>();
            for (int i = startSin; i <= endSin; i++)
            {
                String Filename = "U" + userID + "S" + i;
                DBReader read = new DBReader();
                read.Read(DefaultPath+ Filename + ReadType);
                Averages.Add(read);
            }

            DTW = new int[endSin - startSin+1, 2];

           int[,] DTWaverage = new int[1, 2] { { 0,0} };
            for (int j = 0; j< (endSin - startSin + 1);j++)
            {
                if (Averages[j] == null || Averages[j].pointX ==null) break;

                int[,] tempDTW = BComp_DTW.DTWDistance(selectedFile.pointX, selectedFile.pointY,
                    Averages[j].pointX, Averages[j].pointY);
                DTW[j, 0] = tempDTW[0, 0];
                DTW[j, 1] = tempDTW[0, 1];

                DTWaverage[0, 0] += DTW[j, 0];
                DTWaverage[0, 1] += DTW[j, 1];
               
                Console.WriteLine("DTW"+j+":"+ DTW[j, 0] +","+ DTW[j, 1]);
            }
            return DTWaverage;
        }
    }
}