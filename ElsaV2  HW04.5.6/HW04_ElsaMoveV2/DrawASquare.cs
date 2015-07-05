using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsa
{
    internal class DrawASquare : Person
    {
        private float moveDistance = 20.0f;

        public override Position UpdatePosition()
        {
            base.UpdatePosition();//each side 10 steps

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

        public override void GetInitialPositionLocation()
        {
            shiftPointDistance[0] = 0;
            shiftPointDistance[1] = 70;
            shiftImageDistance[0] = 250;
            shiftImageDistance[1] = -120;
            changeImageSize = 0.8;
            base.GetInitialPositionLocation();
        }
    }
}