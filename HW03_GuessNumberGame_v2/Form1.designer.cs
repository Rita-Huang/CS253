namespace CS253_HW03_GuessNumberGame_v2
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

            this.submmitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 443);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            // 
            // submmitButton
            // 
            this.submmitButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.submmitButton.Location = new System.Drawing.Point(84, 153);
            this.submmitButton.Name = "submmitButton";
            this.submmitButton.Size = new System.Drawing.Size(117, 34);
            this.submmitButton.TabIndex = 7;
            this.submmitButton.Text = "提交";
            this.submmitButton.UseVisualStyleBackColor = true;
            this.submmitButton.Click += new System.EventHandler(this.submmitButton_Click);
            //
            // restartButton
            //
            this.restartButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.restartButton.Location = new System.Drawing.Point(84, 202);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(117, 34);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "重來";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.submmitButton);
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox digitInOne;
        internal System.Windows.Forms.ComboBox digitInTen;
        internal System.Windows.Forms.ComboBox digitInHundred;
        internal System.Windows.Forms.ComboBox digitInThousands;
        internal System.Windows.Forms.Button submmitButton;
        internal System.Windows.Forms.Button restartButton;
    }
}

