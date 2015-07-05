using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsaDrawLine
{
    internal class Person
    {
        public Position position = new Position();

        public Position MoveForward(float dx)
        {
            this.position.X += dx;
            return this.position;
        }
    }
}