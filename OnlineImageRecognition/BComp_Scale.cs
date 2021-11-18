using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BComp_Scale
    {
        public void Scale(float[] x,float[] y, float[] anotherX, float[] anotherY)
        {
            float minX = FindMin(x);
            float anotherMinX = FindMin(anotherX);
            float minY = FindMin(y);
            float anotherMinY = FindMin(anotherY);


            float maxX = FindMax(x);
            float anotherMaxX = FindMax(anotherX);
            float maxY = FindMax(y);
            float anotherMaxY = FindMax(anotherY);

            //distance from max to min
            float DistanceX = Math.Abs(maxX - minX);
            float anotherDistanceX = Math.Abs(anotherMaxX - anotherMinX);
            float DistanceY = Math.Abs( maxY - minY);
            float anotherDistanceY = Math.Abs(anotherMaxY - anotherMinY);

            //calculate thee ratio(anotherPoint/point)
            float ratioX = anotherDistanceX / DistanceX;
            float ratioY = anotherDistanceY / DistanceY;

            //check whether can be divided
            if (float.IsInfinity(ratioX)|| float.IsInfinity(ratioY)|| float.IsNaN(ratioX) || float.IsNaN(ratioY) || (ratioX < 0.1 && ratioX > -0.1) || (ratioY < -0.1 && ratioY > -0.1)) return;
            //scalling anotherPoint
            for (int i = 0; i < anotherX.Length; i++)
            {
                anotherX[i] = anotherX[i]/ratioX;
                anotherY[i] /= ratioY;
            }
        }



        public float FindMin(float[] p)
        {
            float min = (int)p[0];
            for(int i=0;i<p.Length;i++)
            {
                if (min > p[i]) min = p[i];
            }
            return min;
        }

        public float FindMax(float[] p)
        {
            float max = (int)p[0];
            for (int i = 0; i < p.Length; i++)
            {
                if (max < p[i]) max= p[i];
            }
            return max;
        }
    }
}