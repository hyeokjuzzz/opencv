using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenCVApp001
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// var src = new Mat("lenna.jpg", ImreadModes.Color);
			//var dst = new Mat();

			//Cv2.Canny(src, dst,50,200);
			//new Window("src image", src); //opencv 윈도우 라이브러리 창 만들기
			//new Window("dst image", dst); //원본을 가지고 가공한 목적 파일

			//Cv2.WaitKey();
			Console.WriteLine(Cv2.GetVersionString());
			int width = 640;
			int height = 480;
			int rows = 480;
			int cols = 640;

			var color = new Mat("lenna.jpg", ImreadModes.Color);
			var gray = new Mat("lenna.jpg", ImreadModes.Grayscale);
			//모니터로 출력
			new Window("color", color);
			new Window("gray", gray);

			Cv2.WaitKey();

		}
	}
}
