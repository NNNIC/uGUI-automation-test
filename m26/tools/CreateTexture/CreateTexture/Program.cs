using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CreateTexture
{
	class Program
	{
		static void Main(string[] args)
		{
			for(var i = 'A'; i<='Z'; i++)
			{
				var s = i.ToString();
				Create(s, "m_upper_");
			}
			for(var i = 'a'; i<='z'; i++)
			{
				var s = i.ToString();
				Create(s,"m_lower_");
			}
			for(var i = '0'; i<='9'; i++)
			{
				var s = i.ToString();
				Create(s, "m_num_");
			}
		}

		static void Create(string s,string prefix)
		{
			var bmp = new Bitmap(64,64);
			using(var gr = Graphics.FromImage(bmp))
			{
				using(var font = new Font("メイリオ",40)) {
					gr.DrawString(s,font,Brushes.White,5,-5);
				}
			}
			bmp.Save(prefix + s.ToLower() + ".png",System.Drawing.Imaging.ImageFormat.Png);
		}

	}
}
