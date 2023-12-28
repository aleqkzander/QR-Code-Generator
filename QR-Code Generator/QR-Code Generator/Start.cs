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
            var qrData = qrCodeGenerator.CreateQrCode(ContentBox.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCoder.QRCode(qrData);
            QRCodePicture.Image = qrCode.GetGraphic(50);
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                QRCodePicture.Image.Save(saveFileDialog.FileName + "." + ImageFormat.Png);
            }
        }
    }
}
