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
            this.QRCodePicture = new System.Windows.Forms.PictureBox();
            this.QRCodeData = new System.Windows.Forms.TextBox();
            this.GenerateCodeBtn = new System.Windows.Forms.Button();
            this.ExportCodeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodePicture
            // 
            this.QRCodePicture.Location = new System.Drawing.Point(12, 12);
            this.QRCodePicture.Name = "QRCodePicture";
            this.QRCodePicture.Size = new System.Drawing.Size(300, 300);
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
            this.GenerateCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateCodeBtn.Location = new System.Drawing.Point(318, 38);
            this.GenerateCodeBtn.Name = "GenerateCodeBtn";
            this.GenerateCodeBtn.Size = new System.Drawing.Size(349, 23);
            this.GenerateCodeBtn.TabIndex = 2;
            this.GenerateCodeBtn.Text = "Generate QR-Code";
            this.GenerateCodeBtn.UseVisualStyleBackColor = true;
            this.GenerateCodeBtn.Click += new System.EventHandler(this.GenerateCodeBtn_Click);
            // 
            // ExportCodeBtn
            // 
            this.ExportCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportCodeBtn.Location = new System.Drawing.Point(318, 67);
            this.ExportCodeBtn.Name = "ExportCodeBtn";
            this.ExportCodeBtn.Size = new System.Drawing.Size(349, 23);
            this.ExportCodeBtn.TabIndex = 3;
            this.ExportCodeBtn.Text = "Export QR-Code";
            this.ExportCodeBtn.UseVisualStyleBackColor = true;
            this.ExportCodeBtn.Click += new System.EventHandler(this.ExportCodeBtn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 323);
            this.Controls.Add(this.ExportCodeBtn);
            this.Controls.Add(this.GenerateCodeBtn);
            this.Controls.Add(this.QRCodeData);
            this.Controls.Add(this.QRCodePicture);
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
    }
}

