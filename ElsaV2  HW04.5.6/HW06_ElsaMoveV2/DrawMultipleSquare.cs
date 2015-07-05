using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsa
{
    internal class DrawMultipleSquare : Person
    {
        private int stepNumber = 6;
        private int moveDistance = 80;

        private float angle = 17;
        private double coeff;
        private double radian;

        public override Position UpdatePosition()
        {
            base.UpdatePosition();//each side 10 steps

            double[,] LocationMap = new double[3, 2];

            int nowCornerNumber = countMoveTimes / stepNumber;
            for (int i = 0; i <= 1; i++)
            {
                LocationMap[i, 0] = initialImageLocation.X;
                LocationMap[i, 1] = initialImageLocation.Y;
                switch ((nowCornerNumber + i) % 4)
                {
                    case 1:
                        //x = x0 + r * cos(n*theta)
                        //y = y0 + r * sin(n*theta)
                        coeff = 1;
                        radian = Rad((((nowCornerNumber + i) - 1) / 4) * angle);
                        break;

                    case 2:
                        //x = x0 + Sqrt(2) * r * cos(n*theta+45)
                        //y = y0 + Sqrt(2) * r * sin(n*theta+45)
                        coeff = Math.Sqrt(2);
                        radian = Rad((((nowCornerNumber + i) - 1) / 4) * angle + 45);
                        break;

                    case 3:
                        //x = x0 + r * cos(n*theta+90)
                        //y = y0 + r * sin(n*theta+90)
                        coeff = 1;
                        radian = Rad((((nowCornerNumber + i) - 1) / 4) * angle + 90);
                        break;

                    default:
                    case 0:
                        //原點
                        //x = x0
                        //y = y0
                        coeff = 0;
                        radian = 1;
                        break;
                }
                LocationMap[i, 0] += coeff * moveDistance * Math.Cos(radian);
                LocationMap[i, 1] += coeff * moveDistance * Math.Sin(radian);

                LocationMap[i, 0] = LocationMap[i, 0];
                LocationMap[i, 1] = LocationMap[i, 1];
            }
            LocationMap[2, 0] = LocationMap[0, 0] + (LocationMap[1, 0] - LocationMap[0, 0]) / stepNumber * (countMoveTimes % stepNumber);
            LocationMap[2, 1] = LocationMap[0, 1] + (LocationMap[1, 1] - LocationMap[0, 1]) / stepNumber * (countMoveTimes % stepNumber);

            this.position.X = (int)LocationMap[2, 0];
            this.position.Y = (int)LocationMap[2, 1];

            return this.position;
        }

        public override void GetInitialPositionLocation()
        {
            shiftPointDistance[0] = 0;
            shiftPointDistance[1] = 70;
            shiftImageDistance[0] = 250;
            shiftImageDistance[1] = 50;
            changeImageSize = 0.6;
            base.GetInitialPositionLocation();
        }

        public double Rad(float degree)
        {
            return degree * Math.PI / 180;
        }
    }
}