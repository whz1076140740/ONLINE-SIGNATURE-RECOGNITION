using System;
using System.IO;

namespace OnlineImageRecognition
{

    //this class responsible for read x,y point  into buffer
    //and support two int arraies to access x,y
    public class DBReader : DBread
    {
        //read from defined DB location
        private  string FileName = @"Text.txt";
        //point buffer
        private int[] imageBufferX;
        private int[] imageBufferY;
        int length;//numbers of points

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
        //construct
        public DBReader()
        {
            FlushBuffer();
        }

        //access x point float array by dataComponent
        public float[] ReadX() {
            float[] px = new float[imageBufferX.Length];
            for (int i=0;i<imageBufferX.Length;i++)
            {
                px[i] = imageBufferX[i];
            }
            return px;
        }
        //access y point float array by dataComponent
        public float[] ReadY()
        {
            float[] py = new float[imageBufferY.Length];
            for (int i = 0; i < imageBufferY.Length; i++)
            {
                py[i] = imageBufferY[i];
            }
            return py;
        }

        //read the image into image buffer
        public void Read()
        {

         //test path
            FileName = @"././././Task2/U5S23.txt";
            //check the null Filename
            if (!File.Exists(FileName))
            {
                Console.WriteLine("{0} not exist", FileName);
                return;
            }
            using (StreamReader fs = File.OpenText(FileName))
            {
                length = int.Parse(fs.ReadLine());
                imageBufferX = new int[length];
                imageBufferY = new int[length];
                //count the read points
                int PointCount = 0;
                string inputLine;
                //read every point's (x,y) untile the end of file
                while ((inputLine = fs.ReadLine()) != null)
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
            if (imageBufferX == null) return;
            int i = 0;
            while (i != imageBufferX.Length)
            {
                imageBufferX[i] = -1;
                imageBufferY[i] = -1;
                i++;
            }
        }
    }
}