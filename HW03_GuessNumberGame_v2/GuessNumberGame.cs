using System;
using System.Collections.Generic;
using System.ComponentModel;//
using System.Drawing;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//

namespace CS253_HW03_GuessNumberGame_v2
{
    public class GuessNumberGame
    {
        private int[] realAnswer = new int[4];
        private int[] guessAnswer = new int[4];

        private Label label1 = new Label();
        private Label label2 = new Label();
        private RichTextBox messageBox = new RichTextBox();
        private ComboBox digitInThousands = new ComboBox();
        private ComboBox digitInHundreds = new ComboBox();
        private ComboBox digitInTen = new ComboBox();
        private ComboBox digitInOne = new ComboBox();

        public GuessNumberGame()
        {
        }

        public void InitializeComponent(Form1 myform)
        {
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "猜數字遊戲!!";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "選擇你要猜的數字，完成後按提交";
            //
            // digitInOne
            //
            this.digitInOne.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.digitInOne.FormattingEnabled = true;
            this.digitInOne.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.digitInOne.Location = new System.Drawing.Point(189, 109);
            this.digitInOne.Name = "digitInOne";
            this.digitInOne.Size = new System.Drawing.Size(37, 28);
            this.digitInOne.TabIndex = 2;
            //
            // digitInTen
            //
            this.digitInTen.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.digitInTen.FormattingEnabled = true;
            this.digitInTen.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.digitInTen.Location = new System.Drawing.Point(145, 109);
            this.digitInTen.Name = "digitInTen";
            this.digitInTen.Size = new System.Drawing.Size(37, 28);
            this.digitInTen.TabIndex = 3;
            //
            // digitInHundred
            //
            this.digitInHundreds.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.digitInHundreds.FormattingEnabled = true;
            this.digitInHundreds.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.digitInHundreds.Location = new System.Drawing.Point(101, 109);
            this.digitInHundreds.Name = "digitInHundred";
            this.digitInHundreds.Size = new System.Drawing.Size(37, 28);
            this.digitInHundreds.TabIndex = 4;
            //
            // digitInThousands
            //
            this.digitInThousands.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.digitInThousands.FormattingEnabled = true;
            this.digitInThousands.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.digitInThousands.Location = new System.Drawing.Point(57, 109);
            this.digitInThousands.Name = "digitInThousands";
            this.digitInThousands.Size = new System.Drawing.Size(37, 28);
            this.digitInThousands.TabIndex = 5;
            //
            // messageBox
            //
            this.messageBox.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.messageBox.Location = new System.Drawing.Point(288, 77);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(274, 340);
            this.messageBox.TabIndex = 6;
            this.messageBox.Text = "";
            //

            myform.Controls.Add(this.digitInThousands);
            myform.Controls.Add(this.digitInHundreds);
            myform.Controls.Add(this.digitInTen);
            myform.Controls.Add(this.digitInOne);
            myform.Controls.Add(this.label2);
            myform.Controls.Add(this.label1);
            myform.Controls.Add(this.messageBox);
        }

        public void GetRealAnswer()
        {
            Random randomNumber = new Random();
            for (int i = 0; i <= 3; i++)
            {
                realAnswer[i] = randomNumber.Next(0, 10);
                for (int j = i - 1; j >= 0; j--)
                {
                    while (realAnswer[i] == realAnswer[j])
                    {
                        realAnswer[i] = randomNumber.Next(0, 10);
                    }
                }
            }
            messageBox.Text = string.Format("答案是{0}{1}{2}{3}    (測試用)\n", realAnswer[0], realAnswer[1], realAnswer[2], realAnswer[3]);
        }

        //public int[] GetRealAnswer()
        //{
        //    Random randomNumber = new Random();
        //    for (int i = 0; i <= 3; i++)
        //    {
        //        realAnswer[i] = randomNumber.Next(0, 10);
        //        for (int j = i - 1; j >= 0; j--)
        //        {
        //            while (realAnswer[i] == realAnswer[j])
        //            {
        //                realAnswer[i] = randomNumber.Next(0, 10);
        //            }
        //        }
        //    }
        //    return realAnswer;
        //}

        public void GetResult()
        {
            guessAnswer[0] = int.Parse(digitInThousands.Text);
            guessAnswer[1] = int.Parse(digitInHundreds.Text);
            guessAnswer[2] = int.Parse(digitInTen.Text);
            guessAnswer[3] = int.Parse(digitInOne.Text);
            this.messageBox.Text = messageBox.Text + "你猜 " + guessAnswer[0] + guessAnswer[1] + guessAnswer[2] + guessAnswer[3];
            messageBox.Text = string.Format(this.messageBox.Text);
            Judge(guessAnswer);
        }

        public void Judge(int[] guessAnswer)
        {
            int[] result = new int[2] { 0, 0 };

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (i == j && guessAnswer[i] == realAnswer[j])
                        result[0] = result[0] + 1;
                    else if (i != j && guessAnswer[i] == realAnswer[j])
                        result[1] = result[1] + 1;
                }
            }
            this.messageBox.Text = messageBox.Text + "   結果是 " + result[0] + "A" + result[1] + "B\n";
            messageBox.Text = string.Format(this.messageBox.Text);
            if (result[0] == 4)
                this.messageBox.Text = messageBox.Text + "答對了!!!   答案是" + realAnswer[0] + realAnswer[1] + realAnswer[2] + realAnswer[3] + "\n";
        }

        public void RestartGame()
        {
            this.messageBox.Clear();
            GetRealAnswer();
        }
    }
}