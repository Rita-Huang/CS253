namespace Elsa
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startButtom = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButtom
            // 
            this.startButtom.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.startButtom.Location = new System.Drawing.Point(28, 407);
            this.startButtom.Name = "startButtom";
            this.startButtom.Size = new System.Drawing.Size(119, 29);
            this.startButtom.TabIndex = 2;
            this.startButtom.Text = "GO!";
            this.startButtom.UseVisualStyleBackColor = true;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.restartButton.Location = new System.Drawing.Point(28, 442);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(119, 29);
            this.restartButton.TabIndex = 6;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label1.Location = new System.Drawing.Point(28, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "MoveModel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.startButtom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Button startButtom;
        //private System.Windows.Forms.Timer timer;
        //private System.Windows.Forms.PictureBox snoopyImage;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.ComboBox comboBox1;
    }
}

