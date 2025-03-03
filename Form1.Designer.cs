namespace _003
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt01 = new System.Windows.Forms.Button();
            this.text01 = new System.Windows.Forms.TextBox();
            this.text02 = new System.Windows.Forms.TextBox();
            this.bt02 = new System.Windows.Forms.Button();
            this.bt03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt01
            // 
            this.bt01.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt01.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt01.Location = new System.Drawing.Point(89, 62);
            this.bt01.Name = "bt01";
            this.bt01.Size = new System.Drawing.Size(134, 93);
            this.bt01.TabIndex = 0;
            this.bt01.Text = "01";
            this.bt01.UseVisualStyleBackColor = false;
            this.bt01.Click += new System.EventHandler(this.bt01_Click);
            // 
            // text01
            // 
            this.text01.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text01.Location = new System.Drawing.Point(183, 241);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(184, 43);
            this.text01.TabIndex = 1;
            // 
            // text02
            // 
            this.text02.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text02.Location = new System.Drawing.Point(462, 241);
            this.text02.Name = "text02";
            this.text02.Size = new System.Drawing.Size(184, 43);
            this.text02.TabIndex = 2;
            // 
            // bt02
            // 
            this.bt02.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt02.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt02.Location = new System.Drawing.Point(347, 62);
            this.bt02.Name = "bt02";
            this.bt02.Size = new System.Drawing.Size(134, 93);
            this.bt02.TabIndex = 3;
            this.bt02.Text = "02";
            this.bt02.UseVisualStyleBackColor = false;
            this.bt02.Click += new System.EventHandler(this.bt02_Click);
            // 
            // bt03
            // 
            this.bt03.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt03.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt03.Location = new System.Drawing.Point(593, 62);
            this.bt03.Name = "bt03";
            this.bt03.Size = new System.Drawing.Size(134, 93);
            this.bt03.TabIndex = 4;
            this.bt03.Text = "03";
            this.bt03.UseVisualStyleBackColor = false;
            this.bt03.Click += new System.EventHandler(this.bt03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt03);
            this.Controls.Add(this.bt02);
            this.Controls.Add(this.text02);
            this.Controls.Add(this.text01);
            this.Controls.Add(this.bt01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt01;
        private System.Windows.Forms.TextBox text01;
        private System.Windows.Forms.TextBox text02;
        private System.Windows.Forms.Button bt02;
        private System.Windows.Forms.Button bt03;
    }
}

