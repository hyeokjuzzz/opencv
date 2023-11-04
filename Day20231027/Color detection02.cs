using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Mat src = Cv2.ImRead("crow.jpg");
			Mat dst = new Mat(src.Size(), MatType.CV_8UC3);

			Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2HSV);

			Cv2.ImShow("dst", dst);
			Cv2.WaitKey();
			Cv2.DestroyAllWindows();
		}
	}
}
