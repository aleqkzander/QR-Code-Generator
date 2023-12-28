using System.Drawing.Imaging;

namespace QR_Code_Generator
{
    public partial class Start : Form
    {
        private QRCoder.QRCodeGenerator qrCodeGenerator;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            qrCodeGenerator = new();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ContentBox.Text))
            {
                MessageBox.Show("Info", "Please insert data to generate a QR-Code.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var qrData = qrCodeGenerator.CreateQrCode(ContentBox.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCoder.QRCode(qrData);
            QRCodePicture.Image = qrCode.GetGraphic(50);
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (QRCodePicture.Image == null)
            {
                MessageBox.Show("Info", "Genrate a QR-Code first.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                QRCodePicture.Image.Save(saveFileDialog.FileName + "." + ImageFormat.Png);
            }
        }
    }
}
