using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BussinessEntity
    {
        private DBservice DBacess;
        private float[,] points;
        private float[] x;
        private float[] y;

        public BussinessEntity()
        {
            DBacess = new DataAccessComp();
            points = DBacess.AccessEntity();
            ToFloatArray();
        }

        //properties to get points from buffer
        public float[] PointX
        {
            set { }
            get
            {
                return x;
            }
        }
        public float[] PointY
        {
            set { }
            get
            {
                return y;
            }
        }
        //for UI print:convert the float[,] entity to float[] x,y entity type 
        public void ToFloatArray()
        {
            int length= points.Length / 2;
            x = new float[length];
            y = new float[length];
            for (int i = 0; i < length; i++)
            {
                x[i] = points[i, 0];
                y[i] = points[i, 1];
            }
        }
    }
}