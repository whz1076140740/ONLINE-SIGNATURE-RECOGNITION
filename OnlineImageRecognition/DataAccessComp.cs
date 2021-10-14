using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public class DataAccessComp : DBservice
    {
        private DBread Reader;
        private PointConverter Converter;

        public DataAccessComp()
        {
            Converter = new PConverter();
            Reader = new DBReader();
        }

        public float[,] AccessEntity()
        {
            Reader.Read();
            return this.Converter.Convert(Reader.ReadX(),Reader.ReadY());
        }
    }
}