using OpenCvSharp;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;



namespace FlipQuizApp

{

	public partial class Form1 : Form

	{

		private Mat image;

		private Mat x_axis, y_axis, xy_axis, repeat, transpose;



		private void button5_Click(object sender, EventArgs e)

		{

			string path = "C:\\Temp\\img\\flip.jpg";

			using (image = new Mat(path, ImreadModes.Color))

			{

				Mat copyColorImg = image.Clone();

				Mat rep_axis = new Mat();

				Cv2.Repeat(image, 1, 2, rep_axis);

				Bitmap resultBitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rep_axis);

				pictureBox2.Image = resultBitmap;



			}

		}



		private void button6_Click(object sender, EventArgs e)

		{

			string path = "C:\\Temp\\img\\flip.jpg";

			using (image = new Mat(path, ImreadModes.Color))

			{

				Mat copyColorImg = image.Clone();

				Mat trans_axis = new Mat();

				Cv2.Transpose(image, trans_axis);

				Bitmap resultBitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(trans_axis);

				pictureBox2.Image = resultBitmap;



			}

		}



		private void button1_Click(object sender, EventArgs e)

		{

			string path = "C:\\Temp\\img\\flip.jpg";

			using (image = new Mat(path, ImreadModes.Color))

			{



				pictureBox2.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);

			}

		}



		private void button4_Click(object sender, EventArgs e)

		{

			string path = "C:\\Temp\\img\\flip.jpg";

			using (image = new Mat(path, ImreadModes.Color))

			{

				Mat copyColorImg = image.Clone();

				Mat xy_axis = new Mat();

				Cv2.Flip(image, xy_axis, FlipMode.XY);

				Bitmap resultBitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(xy_axis);

				pictureBox2.Image = resultBitmap;



			}

		}



		private void button3_Click(object sender, EventArgs e)

		{

			string path = "C:\\Temp\\img\\flip.jpg";

			using (image = new Mat(path, ImreadModes.Color))

			{

				Mat copyColorImg = image.Clone();

				Mat y_axis = new Mat();

				Cv2.Flip(image, y_axis, FlipMode.Y);

				Bitmap resultBitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(y_axis);

				pictureBox2.Image = resultBitmap;



			}

		}



		public Form1()

		{

			InitializeComponent();

		}



		private void button2_Click(object sender, EventArgs e)

		{

			string path = "C:\\Temp\\img\\flip.jpg";

				using(image = new Mat(path, ImreadModes.Color))

			{

				Mat copyColorImg = image.Clone();

				Mat x_axis = new Mat();

				Cv2.Flip(image, x_axis, FlipMode.X);

				Bitmap resultBitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(x_axis);

				pictureBox2.Image = resultBitmap;



			}



		}

	}

}

