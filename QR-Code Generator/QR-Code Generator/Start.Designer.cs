namespace QR_Code_Generator
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QRCodePicture = new PictureBox();
            ContentBox = new TextBox();
            GenerateBtn = new Button();
            ExportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)QRCodePicture).BeginInit();
            SuspendLayout();
            // 
            // QRCodePicture
            // 
            QRCodePicture.BorderStyle = BorderStyle.Fixed3D;
            QRCodePicture.Location = new Point(12, 12);
            QRCodePicture.Name = "QRCodePicture";
            QRCodePicture.Size = new Size(300, 300);
            QRCodePicture.SizeMode = PictureBoxSizeMode.Zoom;
            QRCodePicture.TabIndex = 0;
            QRCodePicture.TabStop = false;
            // 
            // ContentBox
            // 
            ContentBox.Location = new Point(318, 12);
            ContentBox.Name = "ContentBox";
            ContentBox.Size = new Size(300, 23);
            ContentBox.TabIndex = 1;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(318, 41);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(300, 23);
            GenerateBtn.TabIndex = 2;
            GenerateBtn.Text = "Generate QR-Code";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(318, 70);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(300, 23);
            ExportBtn.TabIndex = 3;
            ExportBtn.Text = "Export QR-Code";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 326);
            Controls.Add(ExportBtn);
            Controls.Add(GenerateBtn);
            Controls.Add(ContentBox);
            Controls.Add(QRCodePicture);
            Name = "Start";
            Text = "QR-Code Generator";
            Load += Start_Load;
            ((System.ComponentModel.ISupportInitialize)QRCodePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox QRCodePicture;
        private TextBox ContentBox;
        private Button GenerateBtn;
        private Button ExportBtn;
    }
}
