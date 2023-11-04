using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231102
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("차량 영상 번호 (0: 종료): ");
				int no;
				if (!int.TryParse(Console.ReadLine(), out no))
					break;

				if (no == 0)
					break;

				// 차량번호 입력
				string fname = string.Format("C:\\Temp\\img\\{0:D2}.jpg", no); // 영상 파일 이름 구성
				Mat image = Cv2.ImRead(fname, ImreadModes.Color);
				if (image.Empty())
				{
					// 영상 파일 예외 처리
					Console.WriteLine(no + "번 영상 파일이 없습니다.");
					continue;
				}

				Mat gray = new Mat();
				Mat sobel = new Mat();
				Mat thImg = new Mat();
				Mat morph = new Mat();
				Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new Size(25, 5), new Point(0, 0));

				Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);
				Cv2.Blur(gray, gray, new Size(5, 5));
				Cv2.Sobel(gray, sobel, MatType.CV_8U, 1, 0, 3);
				Cv2.Threshold(gray, thImg, 120, 255, ThresholdTypes.Binary);
				Cv2.MorphologyEx(thImg, morph, MorphTypes.Close, kernel);

				Cv2.ImShow("image", image);
				Cv2.ImShow("이진 영상", thImg);
				Cv2.ImShow("열림 연산", morph);

				Cv2.WaitKey(0);
			}
		}
	}

}
