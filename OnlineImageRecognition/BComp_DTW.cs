using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OnlineImageRecognition
{
public class BComp_DTW
    {
        private float float_DTW;

        public float float_DTWDistance(float[] s, float[] t)
        {

            int n = s.Length + 1;
            int m = t.Length + 1;
            
            float[,] DTW = new float[n, m];

            for (int i = 1; i < n; i++) DTW[i, 0] = float.PositiveInfinity;
            for (int j = 1; j < m; j++) DTW[0, j] = float.PositiveInfinity;

            DTW[0, 0] = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <m; j++)
                {
                    float cost = Math.Abs(s[(i - 1)] - t[(j - 1)]);
                    DTW[i, j] = cost +minimum(DTW[(i - 1), j],    // insertion
                                                DTW[i, (j - 1)],    // deletion
                                                DTW[(i - 1), (j - 1)]);    // match 
                    /*
                    //test-print matrix
                    Console.Write((int)DTW[i, j]+" ");*/
                }

                /*
                //test-print matrix
                Console.WriteLine(); */
            }
            float_DTW = DTW[n - 1, m - 1];

            /*
            //test-print matrix
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();*/

            return float_DTW;
        }
        private float minimum(float insertion, float deletion, float match)
        {
            float min = insertion;
            if (min > deletion) min = deletion;
            if (min > match) min = match;
            return min;
        }
        private int min(int a, int b) {
            return a < b ? a : b;
        }
        private int max(int a, int b)
        {
            return a > b ? a : b;
        }
        static public int[,] DTWDistance(int[] sx , int[] sy, int[] tx, int[] ty)
        {
            int n = sx.Length+1;
            int m = tx.Length+1;
            int[,] DTWx = new int[n,m]; 
            int[,] DTWy = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    DTWx[i, j] = int.MaxValue;
                    DTWy[i, j] = int.MaxValue;
                }
            }
            DTWx[0, 0] = 0;
            DTWy[0, 0] = 0;
            
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    int costx = Math.Abs(sx[(i-1)]-tx[(j-1)]);
                    DTWx[i, j] = costx + Math.Min(Math.Min(DTWx[i - 1, j],    // insertion
                                                DTWx[i, j - 1]),    // deletion
                                                DTWx[i - 1, j - 1]);    // match 
                    
                    int costy = Math.Abs(sy[(i-1)] - ty[(j-1)]);
                    DTWy[i, j] = costy + Math.Min(Math.Min(DTWy[i - 1, j],    // insertion
                                                DTWy[i, j - 1]),    // deletion
                                                DTWy[i - 1, j - 1]) ;    // match 
                }
            }
            return new int[1, 2] { { DTWx[n-1, m-1], DTWy[n-1, m-1] } };
            
        }
    }
}
 