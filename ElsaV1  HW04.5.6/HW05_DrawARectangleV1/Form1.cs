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

namespace DrawARectangle
{
    public partial class Form1 : Form
    {
        private Person Snoopy = new Person();
        private float velocity = 150.0f;
        private int countMoveTimes = 0;

        private Point pt1 = new Point();
        private Point pt2 = new Point();

        private Position startPosition = new Position();

        public Form1()
        {
            InitializeComponent();
            pt1.X = snoopyImage.Location.X;
            pt1.Y = snoopyImage.Location.Y;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Snoopy.position.X = snoopyImage.Location.X;
            Snoopy.position.Y = snoopyImage.Location.Y;
        }

        private Position UpdatePosition()
        {
            float moveDistance = velocity * timer.Interval / 1000.0f;
            Position returnNewPosition = Snoopy.MoveASquare(countMoveTimes, moveDistance);
            countMoveTimes += 1;
            return returnNewPosition;
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

            pt2.X = snoopyImage.Location.X;
            pt2.Y = snoopyImage.Location.Y;

            if (countMoveTimes % 3 == 0)
                snoopyImage.Image = DrawARectangle.Properties.Resources.snoopy_walk_4;
            else if (countMoveTimes % 3 == 1)
                snoopyImage.Image = DrawARectangle.Properties.Resources.snoopy_walk_5;
            else
                snoopyImage.Image = DrawARectangle.Properties.Resources.snoopy_walk_6;

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