namespace DrawMultipleSuare
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
            this.components = new System.ComponentModel.Container();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.startButtom = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.snoopyImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snoopyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.messageTextBox.Location = new System.Drawing.Point(142, 420);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(558, 38);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.Text = "";
            // 
            // startButtom
            // 
            this.startButtom.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.startButtom.Location = new System.Drawing.Point(22, 420);
            this.startButtom.Name = "startButtom";
            this.startButtom.Size = new System.Drawing.Size(104, 38);
            this.startButtom.TabIndex = 2;
            this.startButtom.Text = "GO!";
            this.startButtom.UseVisualStyleBackColor = true;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // snoopyImage
            // 
            this.snoopyImage.Location = new System.Drawing.Point(331, 152);
            this.snoopyImage.Name = "snoopyImage";
            this.snoopyImage.Size = new System.Drawing.Size(73, 70);
            this.snoopyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snoopyImage.TabIndex = 5;
            this.snoopyImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 487);
            this.Controls.Add(this.snoopyImage);
            this.Controls.Add(this.startButtom);
            this.Controls.Add(this.messageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snoopyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Button startButtom;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox snoopyImage;
    }
}

