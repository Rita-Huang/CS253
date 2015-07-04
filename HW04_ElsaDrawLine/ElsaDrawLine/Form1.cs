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

namespace ElsaDrawLine
{
    public partial class Form1 : Form
    {
        private Person Snoopy = new Person();
        private float velocity = 50.0f;
        private int countMoveTimes = 0;
        private Point startLocation;

        public Form1()
        {
            InitializeComponent();
            Snoopy.name = "Snoopy";
            Snoopy.position.X = 0.0f;
            Snoopy.position.Y = 0.0f;
            startLocation = snoopyImage.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Snoopy.position.X = snoopyImage.Location.X;
            Snoopy.position.Y = snoopyImage.Location.Y;
        }

        private Position UpdatePosition()
        {
            float dx = velocity * timer.Interval / 1000.0f;
            countMoveTimes += 1;
            return Snoopy.MoveForward(dx);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Position position = UpdatePosition();
            snoopyImage.Location = new Point((int)this.Snoopy.position.X, (int)this.Snoopy.position.Y);
            messageTextBox.Text = string.Format("現在位置  x={0},y={1}   countMoveTimes={2}", snoopyImage.Location.X, snoopyImage.Location.Y, countMoveTimes);

            if (countMoveTimes % 3 == 0)
                snoopyImage.Image = ElsaDrawLine.Properties.Resources.snoopy_walk_4;
            else if (countMoveTimes % 3 == 1)
                snoopyImage.Image = ElsaDrawLine.Properties.Resources.snoopy_walk_5;
            else
                snoopyImage.Image = ElsaDrawLine.Properties.Resources.snoopy_walk_6;

            Point drawPoint = new Point();
            drawPoint.X = this.snoopyImage.Location.X;
            drawPoint.Y = this.snoopyImage.Location.Y + 170;
            Draw(drawPoint);
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

        private void Draw(Point pt1)
        {
            startLocation.Y = pt1.Y;
            gp.AddLine(startLocation, pt1);
            Invalidate();
        }
    }
}