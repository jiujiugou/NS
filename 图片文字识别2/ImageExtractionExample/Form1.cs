using System.Windows.Forms;
using Tesseract;
using OpenCvSharp;
namespace ImageExtractionExample
{
    public partial class Form1 : Form
    {
        private System.Drawing.Point startPoint;
        private System.Drawing.Point endPoint;
        private Bitmap selectedImage;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
       
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // 检查是否按下了 Ctrl + V
            {
                if (Clipboard.ContainsImage()) // 检查剪贴板中是否包含图像
                {
                    // 从剪贴板中获取图像并设置到 PictureBox 控件中
                    Image image = Clipboard.GetImage();
                    pictureBox1.Image = image;
                }
            }
        }
        
        private void extractTextButton_Click(object sender, EventArgs e)
        {
            ImagePreprocessing imagePreprocessing = new ImagePreprocessing();
            imagePreprocessing.PreprocessImage(pictureBox1.Image);
            if (pictureBox1.Image != null)
            {
                // 使用 Tesseract 引擎进行文本提取
                using (var engine = new TesseractEngine(@"D:\Code\C#\ImageExtractionExample\ImageExtractionExample\tessdata\", "eng", EngineMode.Default))
                {
                    using (Bitmap img = new Bitmap(pictureBox1.Image))
                    {
                        using (var page = engine.Process(PixConverter.ToPix(img)))
                        {
                            string extractedText = page.GetText();
                            textBox1.Text = extractedText;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先加载图像", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Text = " ";
        }
    }
}
