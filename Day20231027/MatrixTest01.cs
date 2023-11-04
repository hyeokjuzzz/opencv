using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTest01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Mat mat = new Mat();
			mat.Create(MatType.CV_8UC3, new int[] {6,6});
			mat.SetTo(new Scalar(255, 0, 0));
			Console.WriteLine(mat.Dump());

			Mat mat2 = new Mat();	
			mat2.Create(MatType.CV_8UC1,new int[] {3,3});
			mat2.SetTo(new Scalar(100));
			Console.WriteLine();
			Console.WriteLine(mat2.Dump());

			//MatExpr 정적메서드
			Mat mat3 = Mat.Ones(9,9,MatType.CV_8UC1);
			Console.WriteLine();
			Console.WriteLine(mat3.Dump());

			Mat mat4 = Mat.Eye(9,9,MatType.CV_8UC1);
			Console.WriteLine();
			Console.WriteLine(mat4.Dump());

			Mat mat5 = Mat.Zeros(9, 9, MatType.CV_8UC1);
			Console.WriteLine();
			Console.WriteLine(mat5.Dump());

			//요소 한셀만 출력하려면?
			Console.WriteLine(mat5.At<int>(0,0));




		}
	}
}
