using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMultipleSuare
{
    internal class Person
    {
        public Position position = new Position();

        public Position MoveForward(float angle, int nowPedometer, Position initialImageLocation)
        {
            int stepNumber = 6;
            int moveDistance = 100;
            double[,] LocationMap = new double[3, 2];

            double coeff;
            double radian;

            //計算方形corner x.y座標
            int nowCornerNumber = nowPedometer / stepNumber;
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
            LocationMap[2, 0] = LocationMap[0, 0] + (LocationMap[1, 0] - LocationMap[0, 0]) / stepNumber * (nowPedometer % stepNumber);
            LocationMap[2, 1] = LocationMap[0, 1] + (LocationMap[1, 1] - LocationMap[0, 1]) / stepNumber * (nowPedometer % stepNumber);

            this.position.X = (int)LocationMap[2, 0];
            this.position.Y = (int)LocationMap[2, 1];

            return this.position;
        }

        public double Rad(float degree)
        {
            return degree * Math.PI / 180;
        }
    }
}