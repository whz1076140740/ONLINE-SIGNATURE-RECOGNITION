using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class BussinessEntity_Scaled
    {
        private float[,] points;
        private float[] Flx;
        private float[] Fly;

        public float[] PointX
        {
            set { }
            get
            {
                return Flx;
            }
        }
        public float[] PointY
        {
            set { }
            get
            {
                return Fly;
            }
        }

        public void setEntity(float[]x,float[]y)
        {
            PConverter converter = new PConverter();
            points = converter.scale(x,y);
            ToFloatArray();
        }
        //copy new x,y points to Flx,Fly
        public void ToFloatArray()
        {
            int length = points.Length / 2;
            Flx = new float[length];
            Fly = new float[length];
            for (int i = 0; i < length; i++)
            {
                Flx[i] = points[i, 0];
                Fly[i] = points[i, 1];
            }
        }
    }
}