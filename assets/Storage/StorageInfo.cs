using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VDCleaner
{
	public class StorageInfo
	{

		public string Name { get; set; }
		public string Path { get; set; }
		public long Size { get; set; }
		public string Extension { get; set; }
		public string BaseName { get; set; }
		public bool IsDirectory { get; set; }
		public bool IsFile { get; set; }


		public StorageInfo(string path)
		{
			if(path.CheckPath())
			{
				IsFile=File.Exists(path);
				IsDirectory=!IsFile;
			}
		}



	}
}
