using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    //Responsibility: convert float[] type x,y arrays to float[,] 
        /*-- and support find MinMax value of x,y
        MinMax format: MinMax[0, 0 / 1] MinX/MinY
                     : MinMax[1,0/1]MaxX/MaxY --*/

    //Aim: for scale the points from DB to windows
    public class PConverter : PointConverter
    {
        //the draw window size
         const float xSize= (float)300;
         const float ySize= (float)300;


        //convert the received DB point to window's scale's form
        public float[,] Convert(float[] x, float[] y)
        {
            float[,] converter = new float[x.Length, 2];

            float[,] MinMax = Two_DMinMax(x,y);
            for (int i = 0; i < x.Length; i++)
            { 
                   float[,] Normal = Normalize(new float[1, 2] { { x[i], y[i] } },MinMax);
                converter[i, 0] = xSize * Normal[0, 0];
                converter[i, 1] = ySize * Normal[0, 1];
            }
            return converter;
        }

        //normalize the point for scalling points to the window
            //Formula: NormalX = (x-MinX)/(MaxX-MinX)
        public float[,] Normalize(float[,] p,float[,] MinMax)
        {
            float[,] Normal = new float[1, 2];
            float[,] unit = new float[1, 2] { {(MinMax[1,0]- MinMax[0, 0]), (MinMax[1, 1] - MinMax[0, 1]) } };
            //if unit = Max-Min ==0, then return a 0,0 normal back
            if (unit[0, 0].Equals(unit[0, 1]) && unit[0, 0].Equals(0)) return new float[1, 2] { {0,0 } };
            Normal[0, 0] = (p[0, 0]-MinMax[0,0]) / unit[0,0];
            Normal[0, 1] = (p[0, 1]-MinMax[0,1]) / unit[0,1]; 
            return Normal;
        }
        //check the Minmum and Maxmum value of a two dimension float array
        //return format: MinMax[0,0/1]MinX/MinY
                     //: MinMax[1,0/1]MaxX/MaxY
        //For using in normalization
        private float[,] Two_DMinMax(float[] x,float[] y)
        {
            float MinX = x[ 0], MinY = y[0 ];
            float MaxX = x[ 0], MaxY = y[0 ]; 
            for (int i =0;i<x.Length; i++)
            { 
                if (MinX > x[i ]) MinX = x[i];
                if (MaxX < x[i ]) MaxX = x[i];
                if (MinY > y[i ]) MinY = y[i];
                if (MaxY < y[i ]) MaxY = y[i];
            }
            float[,] MinMax = new float[2, 2] { { MinX,MinY},{ MaxY,MaxY} };
            return MinMax;
        } 





        //Calculate the bias derivate of a (x,y)
        //useless!!! But is one of my mistake of creation ！！！
        public float[,] XYbiasDerivative(float[,] p)
        {
            float[,] BiasDer = new float[1, 2];
            float unit = (float)Math.Sqrt((p[0, 0] * p[0, 0]) + (p[0, 1] * p[0, 1]));
            BiasDer[0, 0] = p[0, 0] / unit;
            BiasDer[0, 1] = p[0, 1] / unit;
            return BiasDer;
        }
    }
}