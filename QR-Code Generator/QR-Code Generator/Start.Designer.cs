namespace QR_Code_Generator
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.QRCodePicture = new System.Windows.Forms.PictureBox();
            this.QRCodeData = new System.Windows.Forms.TextBox();
            this.GenerateCodeBtn = new System.Windows.Forms.Button();
            this.ExportCodeBtn = new System.Windows.Forms.Button();
            this.QRCodeDataText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodePicture
            // 
            this.QRCodePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRCodePicture.Location = new System.Drawing.Point(12, 12);
            this.QRCodePicture.Name = "QRCodePicture";
            this.QRCodePicture.Size = new System.Drawing.Size(300, 300);
            this.QRCodePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRCodePicture.TabIndex = 0;
            this.QRCodePicture.TabStop = false;
            // 
            // QRCodeData
            // 
            this.QRCodeData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QRCodeData.Location = new System.Drawing.Point(318, 12);
            this.QRCodeData.Name = "QRCodeData";
            this.QRCodeData.Size = new System.Drawing.Size(349, 20);
            this.QRCodeData.TabIndex = 1;
            // 
            // GenerateCodeBtn
            // 
            this.GenerateCodeBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.GenerateCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateCodeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.GenerateCodeBtn.Location = new System.Drawing.Point(318, 38);
            this.GenerateCodeBtn.Name = "GenerateCodeBtn";
            this.GenerateCodeBtn.Size = new System.Drawing.Size(349, 23);
            this.GenerateCodeBtn.TabIndex = 2;
            this.GenerateCodeBtn.Text = "Generate QR-Code";
            this.GenerateCodeBtn.UseVisualStyleBackColor = false;
            this.GenerateCodeBtn.Click += new System.EventHandler(this.GenerateCodeBtn_Click);
            // 
            // ExportCodeBtn
            // 
            this.ExportCodeBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExportCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportCodeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ExportCodeBtn.Location = new System.Drawing.Point(318, 67);
            this.ExportCodeBtn.Name = "ExportCodeBtn";
            this.ExportCodeBtn.Size = new System.Drawing.Size(349, 23);
            this.ExportCodeBtn.TabIndex = 3;
            this.ExportCodeBtn.Text = "Export QR-Code";
            this.ExportCodeBtn.UseVisualStyleBackColor = false;
            this.ExportCodeBtn.Click += new System.EventHandler(this.ExportCodeBtn_Click);
            // 
            // QRCodeDataText
            // 
            this.QRCodeDataText.Location = new System.Drawing.Point(318, 96);
            this.QRCodeDataText.Name = "QRCodeDataText";
            this.QRCodeDataText.ReadOnly = true;
            this.QRCodeDataText.Size = new System.Drawing.Size(349, 216);
            this.QRCodeDataText.TabIndex = 4;
            this.QRCodeDataText.Text = "1. Enter your information in the box on the top\n2. Generate your QR-Code\n3. Expor" +
    "t your QR-Code\n\nhttps://github.com/codebude/QRCoder";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 323);
            this.Controls.Add(this.QRCodeDataText);
            this.Controls.Add(this.ExportCodeBtn);
            this.Controls.Add(this.GenerateCodeBtn);
            this.Controls.Add(this.QRCodeData);
            this.Controls.Add(this.QRCodePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Text = "QR-Code Generator";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRCodePicture;
        private System.Windows.Forms.TextBox QRCodeData;
        private System.Windows.Forms.Button GenerateCodeBtn;
        private System.Windows.Forms.Button ExportCodeBtn;
        private System.Windows.Forms.RichTextBox QRCodeDataText;
    }
}

