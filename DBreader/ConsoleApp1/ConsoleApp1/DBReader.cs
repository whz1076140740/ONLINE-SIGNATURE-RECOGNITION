using System;
using System.IO;

namespace ConsoleApp1
{
    //this class responsible for read x,y point  into buffer
        //and support two int arraies to access x,y
    public class DBReader
    {
        //read from defined DB location
        private const string FileName = "Text.txt";
        //point buffer
        private int[] imageBufferX = new int[400];
        private int[] imageBufferY = new int[400];

        //properties to get points from buffer
        public int[] pointX
        {
            set { }
            get
            {
                return imageBufferX;
            }
        }
        public int[] pointY
        {
            set { }
            get
            {
                return imageBufferY;
            }
        }

        public DBReader()
        {
            FlushBuffer();
        }

        //read the image into image buffer
        public void Read()
        {
            //check the null Filename
            if (!File.Exists(FileName))
            {
                Console.WriteLine("{0} not exist",FileName); 
                return ;
            }
            using (StreamReader fs = File.OpenText(FileName))
            {
                //count the read points
                int PointCount = 0;
                string inputLine;
                //read every point's (x,y) untile the end of file
                while ((inputLine = fs.ReadLine())!=null)
                {
                    string[] input = inputLine.Split(' ');
                    imageBufferX[PointCount] = int.Parse(input[0]);
                    imageBufferY[PointCount] = int.Parse(input[1]);
                    ++PointCount;
                }
            }
        }

        //flush buffer to 0 value
        public void FlushBuffer()
        {
            int i = 0;
            while (i!=400)
            {
                imageBufferX[i] = -1;
                imageBufferY[i] = -1;
                i++;
            }
        }
    }
}