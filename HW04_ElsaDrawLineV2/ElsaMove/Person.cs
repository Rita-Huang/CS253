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
    internal class Person : Control
    {
        public Position position = new Position();

        private int countMoveTimes = 0;

        protected RichTextBox messageTextBox = new System.Windows.Forms.RichTextBox();
        protected Timer timer = new System.Windows.Forms.Timer();
        private PictureBox Image = new System.Windows.Forms.PictureBox();
        private ComboBox moveModelListBox = new System.Windows.Forms.ComboBox();

        private GraphicsPath gp = new GraphicsPath();
        private Point pt1 = new Point();
        private Point pt2 = new Point();

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

            //
            // moveModelListBox
            //
            this.moveModelListBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.moveModelListBox.FormattingEnabled = true;
            this.moveModelListBox.Items.AddRange(new object[] {
            "Draw a line",
            "Draw a square",
            "Draw mutiple square"});
            this.moveModelListBox.Location = new System.Drawing.Point(161, 367);
            this.moveModelListBox.Name = "moveModelListBox";
            this.moveModelListBox.Size = new System.Drawing.Size(256, 32);
            this.moveModelListBox.TabIndex = 8;
            this.moveModelListBox.Text = "Choose One Move Model";

            myform.Controls.Add(this.moveModelListBox);
            myform.Controls.Add(this.Image);
            myform.Controls.Add(this.messageTextBox);
        }

        public void GetInitialPositionLocation()
        {
            this.Image.Location = new System.Drawing.Point(26, 120);
            this.position.X = Image.Location.X;
            this.position.Y = Image.Location.Y;
            pt1.X = Image.Location.X;
            pt1.Y = Image.Location.Y + 170;
        }

        public virtual Position UpdatePosition()
        {
            countMoveTimes += 1;
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
            position = UpdatePosition();
            Image.Location = new Point((int)this.position.X, (int)this.position.Y);
            messageTextBox.Text = string.Format("現在位置  x={0},y={1}   countMoveTimes={2}", Image.Location.X, Image.Location.Y, countMoveTimes);

            if (countMoveTimes % 3 == 0)
                Image.Image = Elsa.Properties.Resources.walk_1;
            else if (countMoveTimes % 3 == 1)
                Image.Image = Elsa.Properties.Resources.walk_2;
            else
                Image.Image = Elsa.Properties.Resources.walk_3;

            if (countMoveTimes > 0)
            {
                pt1.X = pt2.X;
                pt1.Y = pt2.Y;
            }
            pt2.X = Image.Location.X;
            pt2.Y = Image.Location.Y + 170;
            Draw(pt1, pt2);
        }

        public void MoveForward()
        {
            timer.Enabled = !timer.Enabled;
        }
    }
}