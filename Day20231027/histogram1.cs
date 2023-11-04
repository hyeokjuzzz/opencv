using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ex2._7
{
	//히스토그램
	internal class Program
	{
		static void Main(string[] args)
		{
			Mat src = Cv2.ImRead("C:\\Temp\\img\\image.jpg");
			Mat gray = new Mat(); //비어있는 화면
			Mat hist = new Mat();
			Mat result = Mat.Ones(new Size(256,src.Height),MatType.CV_8UC1);
			Mat dst = new Mat();


			//컬러 -> 흑백
			Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
			//히스토그램 그리기
			Cv2.CalcHist(new Mat[] {gray},new int[] { 0 },null,hist,1,new int[] { 256 }, new Rangef[] { new Rangef(0, 256) } );


			//평탄화
			Cv2.Normalize(hist, hist, 0, 255, NormTypes.MinMax);

			for(int i =0; i < hist.Rows; i++)
			{
				Cv2.Line(result, new Point(i, src.Height), new Point(i, src.Height - hist.Get<float>(i)), Scalar.White);
			}

			Cv2.HConcat(new Mat[] { gray, result }, dst);
			Cv2.ImShow("dst", dst);
			Cv2.WaitKey(0);
			Cv2.DestroyAllWindows();
			Cv2.ImShow("원본파일", src); //Imshow 함수 자체가 제목을 적어줘야하는 수고가 필요함
			Cv2.ImShow("gray", gray);
			Cv2.ImShow("hist",hist);

			Cv2.WaitKey(0);

		}
	}
}
