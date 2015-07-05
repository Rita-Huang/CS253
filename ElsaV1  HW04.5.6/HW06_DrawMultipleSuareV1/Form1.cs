using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMultipleSuare
{
    public partial class Form1 : Form
    {
        private Person Snoopy = new Person();
        private int countMoveTimes = 0;

        private Point pt1 = new Point();
        private Point pt2 = new Point();
        private int[] ptShiftDistance = new int[2] { -5, 80 };
        private Position initialImageLocation = new Position();

        public Form1()
        {
            InitializeComponent();
            initialImageLocation.X = snoopyImage.Location.X;
            initialImageLocation.Y = snoopyImage.Location.Y;
            pt1.X = snoopyImage.Location.X + ptShiftDistance[0];
            pt1.Y = snoopyImage.Location.Y + ptShiftDistance[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Snoopy.position.X = snoopyImage.Location.X;
            Snoopy.position.Y = snoopyImage.Location.Y;
        }

        private Position UpdatePosition()
        {
            Position returnPosition = Snoopy.MoveForward(17, countMoveTimes, initialImageLocation);
            countMoveTimes += 1;
            return returnPosition;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (countMoveTimes > 0)
            {
                pt1.X = pt2.X;
                pt1.Y = pt2.Y;
            }

            Position position = UpdatePosition();
            snoopyImage.Location = new Point((int)this.Snoopy.position.X, (int)this.Snoopy.position.Y);
            messageTextBox.Text = string.Format("現在位置  x={0},y={1}   countMoveTimes={2}", snoopyImage.Location.X, snoopyImage.Location.Y, countMoveTimes);

            pt2.X = snoopyImage.Location.X + ptShiftDistance[0];
            pt2.Y = snoopyImage.Location.Y + ptShiftDistance[1];

            if (countMoveTimes % 3 == 0)
                snoopyImage.Image = DrawMultipleSuare.Properties.Resources.snoopy_walk_4;
            else if (countMoveTimes % 3 == 1)
                snoopyImage.Image = DrawMultipleSuare.Properties.Resources.snoopy_walk_5;
            else
                snoopyImage.Image = DrawMultipleSuare.Properties.Resources.snoopy_walk_6;

            Draw(pt1, pt2);
        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private GraphicsPath gp = new GraphicsPath();

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawPath(new Pen(Color.Red), gp);
        }

        private void Draw(Point pt1, Point pt2)
        {
            gp.AddLine(pt1, pt2);
            Invalidate();
        }
    }
}