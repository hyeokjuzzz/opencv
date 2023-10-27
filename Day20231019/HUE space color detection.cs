using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// HUE 공간 색상 검출
			Mat src = Cv2.ImRead("orange.jpg");
			Mat hsv = new Mat(src.Size(), MatType.CV_8UC3);
			Mat dst = new Mat(src.Size(), MatType.CV_8UC3);

			Cv2.CvtColor(src, hsv, ColorConversionCodes.BGR2HSV);
			Mat[] HSV = Cv2.Split(hsv);
			Mat H_orange = new Mat(src.Size(), MatType.CV_8UC1);
			Cv2.InRange(HSV[0], new Scalar(8), new Scalar(20), H_orange);

			Cv2.BitwiseAnd(hsv, hsv, dst, H_orange);
			Cv2.CvtColor(dst, dst, ColorConversionCodes.HSV2BGR);

			Cv2.ImShow("orange", dst);
			Cv2.WaitKey();
			Cv2.DestroyAllWindows();




		}
	}
}
