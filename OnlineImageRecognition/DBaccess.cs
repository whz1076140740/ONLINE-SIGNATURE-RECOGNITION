using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public interface PointConverter
    {
        float[,] Convert(float[] x,float[] y);
    }
}