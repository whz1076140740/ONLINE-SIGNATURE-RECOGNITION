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
        private float[] Flx;
        private float[] Fly;
        private int[] Intx;
        private int[] Inty;
        private String Fname;
        public BussinessEntity(String Fname)
        {
            this.Fname = Fname;
            DBacess = new DataAccessComp();
            points = DBacess.AccessEntity(Fname);
            
            ToFloatArray();
            ToIntArray();
        }

        //properties to get points from buffer
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

        public int[] PointX_Int
        {
            set { }
            get
            {
                return Intx;
            }
        }
        public int[] PointY_Int
        {
            set { }
            get
            {
                return Inty;
            }
        }
        //for UI print:convert the float[,] entity to float[] x,y entity type 
        public void ToFloatArray()
        {
            int length= points.Length / 2;
            Flx = new float[length];
            Fly = new float[length];
            for (int i = 0; i < length; i++)
            {
                Flx[i] = points[i, 0];
                Fly[i] = points[i, 1];
            }
        }
        public void ToIntArray()
        {
            DBReader intRead = new DBReader();
            intRead.Read( Fname);
            Intx=intRead.pointX;
            Inty=intRead.pointY;
        }
    }
}