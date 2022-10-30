using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VDCleaner.assets.GraphicsProcessing.ImageData
{
	public class ImageDataCollection
	{

		public ImageData[] Data;
		public long[] XCoords;
		public long[] YCoords;
		private ulong Count=0;
		public Bitmap BitmapData;
		private string _FilePath;
		
		private ulong _Width;
		private ulong _Height;

		public ulong Width
		{
			get
			{
				return _Width;
			}
		}

		public ulong Height
		{
			get
			{
				return _Height;
			}
		}

		public string FilePath
		{
			get
			{
				return _FilePath;
			}
			set
			{
				if(value.IsImageFile())
				{
					_FilePath=value;
					BitmapData=new Bitmap(value);
					_Width=(ulong)BitmapData.Width;
					_Height=(ulong)BitmapData.Height;
				}
			}
		}

		public ImageDataCollection()
		{

		}




	}
}
