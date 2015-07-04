using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS253_HW03_GuessNumberGame_v2
{
    public partial class Form1 : Form  //
    {
        private GuessNumberGame player = new GuessNumberGame();
        public int[] realAnswer;
        private int[] guessAnswer = new int[4];
        private int[] result = new int[2];

        public Form1()
        {
            InitializeComponent();
            player.InitializeComponent(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.GetRealAnswer();
        }

        private void submmitButton_Click(object sender, EventArgs e)
        {
            player.GetResult();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            player.RestartGame();
        }
    }
}