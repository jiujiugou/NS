using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageExtractionExample
{
    public class ImagePreprocessing
    {

        public Image PreprocessImage(Image image)
        {
            // 将System.Drawing.Image转换为Bitmap
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

            // 创建OpenCVSharp中的Mat对象
            Mat inputImage = OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);
            // 去噪
            Mat denoisedImage = inputImage.GaussianBlur(new OpenCvSharp.Size(3, 3), 0);
            // 二值化
            Mat binaryImage = denoisedImage.CvtColor(ColorConversionCodes.BGR2GRAY);
            binaryImage = binaryImage.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            // 增强对比度
            Mat contrastEnhancedImage = binaryImage.EqualizeHist();
            Bitmap map = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(contrastEnhancedImage);
            
            // 返回预处理后的图像
            return map;
        }
    }
}
