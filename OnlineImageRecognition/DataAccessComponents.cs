using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class PConverter : PointConverter
    {
        //the draw window size
         const float xSize= (float)700;
         const float ySize= (float)500;


        //convert the received DB point to window's scale's form
        public float[,] Convert(float[] x, float[] y)
        {
            float[,] converter = new float[x.Length, 2];
            for (int i = 0; i < x.Length; i++)
            { 
                   float[,] Normal = Normalize(new float[1, 2] { { x[i], y[i] } } );
                converter[i, 0] = xSize * Normal[0, 0];
                converter[i, 1] = ySize * Normal[0, 1];
            }
            return converter;
        }

        //normalize the point for scalling to the window
        public float[,] Normalize(float[,] p)
        {
            float[,] Normal = new float[1, 2];
            float unit = (float)Math.Sqrt((p[0, 0] * p[0, 0]) + (p[0, 1] * p[0, 1]));
            Normal[0, 0] = p[0, 0] / unit;
            Normal[0, 1] = p[0, 1] / unit; 
            return Normal;
        }
    }
}