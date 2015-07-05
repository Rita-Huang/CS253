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

namespace Elsa
{
    public partial class Form1 : Form
    {
        private DrawALine Snoopy = new DrawALine();

        public Form1()
        {
            InitializeComponent();
            Snoopy.InitializeItems(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Snoopy.GetInitialPositionLocation();
        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            Snoopy.MoveForward();
        }
    }
}