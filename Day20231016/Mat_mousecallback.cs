using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Mat src = new Mat(new Size(500,500),MatType.CV_8UC3,new Scalar(255, 255, 255));
			Cv2.ImShow("draw", src);
			//마우스 callback 객체 생성
			MouseCallback cvMouseCallback = new MouseCallback(Event);
			//부착  or 등록
			Cv2.SetMouseCallback("draw", cvMouseCallback,src.CvPtr);
			Cv2.WaitKey(0);
		}
		static void Event(MouseEventTypes @event,int x, int y, MouseEventFlags Flags,IntPtr Userdata)
		{
			Mat data = new Mat(Userdata);

			if(Flags == MouseEventFlags.LButton)
			{
				Cv2.Circle(data, new Point(x, y), 10, new Scalar(0, 0, 255), -1);
				Cv2.ImShow("draw", data);
				
			}
		}
	}
}
