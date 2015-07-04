using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;//

namespace Elsa
{
    internal class DrawALine : Person
    {
        private float velocity = 50.0f;

        public override Position UpdatePosition()
        {
            base.UpdatePosition();
            float dx = velocity * timer.Interval / 1000.0f;
            this.position.X += dx;
            return this.position;
        }
    }
}