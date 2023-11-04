using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace Ex4._61
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Mat src = new Mat(new Size(500, 500), MatType.CV_8UC3, new Scalar(255, 255, 255));
			Cv2.ImShow("draw", src);
			//마우스이벤트 콜백 객체 생성
			MouseCallback cvMousecallback = new MouseCallback(Event);
			//부탁 or 등록
			Cv2.SetMouseCallback("draw", cvMousecallback, src.CvPtr);
							
			Cv2.WaitKey(0);
			Cv2.DestroyAllWindows();
		} 
		static void Event(MouseEventTypes @event,int x, int y,MouseEventFlags flags,IntPtr userdata) 
		{
			Mat data = new Mat(userdata);
			
			if(@event == MouseEventTypes.LButtonDown)
			{
				Console.WriteLine("마우스 왼쪽버튼 누르기");
			}
			else if (@event == MouseEventTypes.LButtonDoubleClick)
			{
				Console.WriteLine("마우스 왼쪽버튼 더블클릭");
			}
			else if (@event == MouseEventTypes.RButtonDown)
			{
				Console.WriteLine("마우스 오른쪽 버튼 누르기");
			}
			else if (@event == MouseEventTypes.RButtonDoubleClick)
			{
				Console.WriteLine("마우스 오른쪽 버튼 더블클릭");
			}
		}
	} 
}
