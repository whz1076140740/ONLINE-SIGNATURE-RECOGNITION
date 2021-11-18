using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    //Responsible for shift the entity points set to (0,0)
    public class BComp_Shift
    {
        //the shift coordinate start position(10,10)
        static int Normalscale = 0;
        //no need scale in this place the draw Window will handle precise shift

        //shift to origin
        public void shift_ToOrigin(float[] x, float[] y)
        {
            int shiftX, shiftY;

            shiftX = (int)findMin(x);
            shiftY = (int)findMin(y);
            //shift
            for (int i = 0; i < x.Length; i++)
            {
                x[i] -= shiftX;
                y[i] -= shiftY;
            }
        }
        public float findMin(float[] p)
        {
            float min = float.PositiveInfinity;
            for (int i=0;i<p.Length;i++)
            {
                if (p[i] == 0) continue;
                if (min > p[i]) min = p[i];
            }
            return min;
        }
        //shift to closet distance of origin
        public void shift_ByDistanceToOrigin(float[] x, float[] y)
        {
            int[] distance = DistanceToOrigin(x, y);
            int distanceIndex = FindMinMumDistanceIndex(distance);
            int shiftX = (int)x[distanceIndex], shiftY = (int)y[distanceIndex];

            //shift
            for (int i = 0; i < x.Length; i++)
            {
                x[i] -= shiftX;
                y[i] -= shiftY;
            }
        }

        private int[] DistanceToOrigin(float[] x, float[] y)
        {
            int[] DistanceToOri = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                //from distance equation
                //eq:sqrt((x2-x1)^2+(y2-y1)^2)
                int distance = (int)Math.Sqrt(x[i] * x[i] + y[i] * y[i]);
                DistanceToOri[i] = distance;
            }
            return DistanceToOri;
        }
        //find Min
        //overload

        public int FindMinMumDistanceIndex(int[] distance)
        {
            int minD = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                if (distance[minD] > distance[i])
                {
                    minD = i;
                }
            }
            return minD;
        }

    }
}