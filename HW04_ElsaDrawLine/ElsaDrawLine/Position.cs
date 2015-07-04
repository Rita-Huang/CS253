using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsaDrawLine
{
    internal class Position
    {
        private float x;

        public float X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    x = 0;
                else if (value > 600)
                    x = 600;
                else
                    x = value;
            }
        }

        private float y;

        public float Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    y = 0;
                else if (value > 300)
                    y = 300;
                else
                    y = value;
            }
        }
    }
}