using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineImageRecognition
{
    public interface DBread
    {
        void Read();
        void FlushBuffer();
    }
}