using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace MatTest02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Mat m1 = new Mat(3, 3, MatType.CV_16UC1);
			Console.WriteLine(m1.Dump());	

			for(int i = 0; i < m1.Rows; i++)
			{
				for(int j = 0; j <m1.Cols; j++)
				{
					m1.At<int>(i, j) = 100;
				}
			}
			//출력
			//Console.WriteLine(m1.Dump() );

			for (int i = 0; i < m1.Rows; i++)
			{
				for (int j = 0; j < m1.Cols; j++)
				{
					Console.WriteLine(m1.At<int>(i, j) + " ");
				}
			}
			Console.WriteLine(m1.Dump());
			Console.WriteLine();
			//p72
			IList<int> Sizes = new List<int>() { 7,7};
			Mat m2 = new Mat(Sizes, MatType.CV_8UC3);
			Console.WriteLine(m2.Dump());
		}
	}
}
