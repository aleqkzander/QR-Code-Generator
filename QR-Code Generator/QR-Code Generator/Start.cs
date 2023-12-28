using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QR_Code_Generator
{
    public partial class Start : Form
    {
        private QRCodeGenerator qrCodeGenerator;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            qrCodeGenerator = new QRCodeGenerator();
        }

        private void GenerateCodeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QRCodeData.Text))
            {
                MessageBox.Show("Info", "Please insert data to generate a QR-Code.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var qrData = qrCodeGenerator.CreateQrCode(QRCodeData.Text, QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCode(qrData);
            QRCodePicture.Image = qrCode.GetGraphic(50);
        }

        private void ExportCodeBtn_Click(object sender, EventArgs e)
        {
            if (QRCodePicture.Image == null)
            {
                MessageBox.Show("Info", "Genrate a QR-Code first.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG files (*.png)|*.png"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                QRCodePicture.Image.Save(saveFileDialog.FileName + "." + ImageFormat.Png);
            }
        }
    }
}
