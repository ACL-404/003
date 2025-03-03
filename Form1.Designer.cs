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
            this.SuspendLayout();
            // 
            // bt01
            // 
            this.bt01.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt01.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt01.Location = new System.Drawing.Point(151, 62);
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
            this.text01.Location = new System.Drawing.Point(151, 241);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(184, 43);
            this.text01.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

