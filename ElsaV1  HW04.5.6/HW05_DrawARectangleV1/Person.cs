using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawARectangle
{
    internal class Person
    {
        public Position position = new Position();

        public Position MoveASquare(int countMoveTimes, float moveDistance)
        {
            //each side 10 steps
            switch ((countMoveTimes / 10) % 4)
            {
                case 0:
                    this.position.X += moveDistance;
                    break;

                case 1:
                    this.position.Y += moveDistance;
                    break;

                case 2:
                    this.position.X -= moveDistance;
                    break;

                case 3:
                    this.position.Y -= moveDistance;
                    break;
            }
            return this.position;
        }
    }
}