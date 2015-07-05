using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsa
{
    internal class DrawALine : Person
    {
        private float dx = 5.0f;

        public override Position UpdatePosition()
        {
            base.UpdatePosition();
            this.position.X += dx;
            return this.position;
        }

        public override void GetInitialPositionLocation()
        {
            shiftPointDistance[0] = 0;
            shiftPointDistance[1] = 70;
            //shiftImageDistance[0] = 0;
            //shiftImageDistance[1] = 100;
            // changeImageSize = 0.8;
            base.GetInitialPositionLocation();
        }
    }
}