using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//
using System.Drawing;//
using System.Drawing.Drawing2D;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//

namespace Elsa
{
    internal class Person : Form
    {
        public Position position = new Position();
        protected int countMoveTimes;
        protected Position initialImageLocation = new Position();

        //Panel items
        protected RichTextBox messageTextBox = new System.Windows.Forms.RichTextBox();

        protected Timer timer = new System.Windows.Forms.Timer();
        private PictureBox Image = new System.Windows.Forms.PictureBox();

        //draw used
        private GraphicsPath gp = new GraphicsPath();

        private Point pt1 = new Point();
        private Point pt2 = new Point();

        //subclass change location
        protected int[] shiftPointDistance = new int[2] { 0, 0 };

        protected int[] shiftImageDistance = new int[2] { 0, 0 };
        protected double changeImageSize = 1.0;

        public virtual void InitializeItems(Form1 myform)
        {
            //
            // messageTextBox
            //
            this.messageTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.messageTextBox.Location = new System.Drawing.Point(161, 407);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(454, 64);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.Text = "";
            //
            // timer
            //
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            //
            // Image
            //
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();

            this.Image.Location = new System.Drawing.Point(26, 128);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(140, 185);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 5;
            this.Image.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();

            myform.Controls.Add(this.Image);
            myform.Controls.Add(this.messageTextBox);
        }

        public virtual void GetInitialPositionLocation()
        {
            this.Image.Location = new System.Drawing.Point(26 + shiftImageDistance[0], 120 + shiftImageDistance[1]);
            this.Image.Size = new System.Drawing.Size((int)(140 * changeImageSize), (int)(185 * changeImageSize));
            this.position.X = Image.Location.X;
            this.position.Y = Image.Location.Y;
            pt1.X = Image.Location.X + shiftPointDistance[0];
            pt1.Y = Image.Location.Y + shiftPointDistance[1];
            initialImageLocation.X = Image.Location.X;
            initialImageLocation.Y = Image.Location.Y;
            countMoveTimes = 0;
        }

        public virtual Position UpdatePosition()
        {
            return this.position;
        }

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

        private void timer_Tick(object sender, EventArgs e)
        {
            if (countMoveTimes > 0)
            {
                pt1.X = pt2.X;
                pt1.Y = pt2.Y;
            }

            position = UpdatePosition();
            Image.Location = new Point((int)this.position.X, (int)this.position.Y);
            messageTextBox.Text = string.Format("現在位置  x={0},y={1}   countMoveTimes={2}", Image.Location.X, Image.Location.Y, countMoveTimes);

            pt2.X = Image.Location.X + shiftPointDistance[0];
            pt2.Y = Image.Location.Y + shiftPointDistance[1];

            if (countMoveTimes % 3 == 0)
                Image.Image = Elsa.Properties.Resources.walk_1;
            else if (countMoveTimes % 3 == 1)
                Image.Image = Elsa.Properties.Resources.walk_2;
            else
                Image.Image = Elsa.Properties.Resources.walk_3;

            Draw(pt1, pt2);
            countMoveTimes += 1;
        }

        public void MoveForward()
        {
            timer.Enabled = !timer.Enabled;
        }

        //public void Restart()
        //{
        //    this.Image.Location = new System.Drawing.Point(initialImageLocation.X, initialImageLocation.Y);

        //    //initialImageLocation.X = Image.Location.X;
        //    //initialImageLocation.Y = Image.Location.Y;
        //}
    }
}