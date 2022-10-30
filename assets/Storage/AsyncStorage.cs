using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VDCleaner
{
	public class AsyncStorage
	{

		public long Size=0;
		private bool _Complete=false;
		public List<StorageInfo> Items=new List<StorageInfo>();
		public bool Complete
		{
			get
			{
				return _Complete;
			}
		}

		public async void GetSizes(string path)
		{
			_Complete=false;
			if(path.CheckPath())
			{
				if(File.Exists(path))
					Size+=new FileInfo(path).Length;
				else if(Directory.Exists(path))
				{
					await Task.Run(()=>ScanSize_Dirs(path));
				}
			}
		}

		public async Task<List<StorageInfo>> ScanDir(string path,int index=0,List<StorageInfo> buffer=null)
		{
			List<StorageInfo> res=new List<StorageInfo>();
			if(path.CheckPath())
				if(Directory.Exists(path))
				{
					int i=buffer!=null&&index>-1 ? index : 0;
					if(buffer!=null)
						res=buffer;
					ulong ct=GetTimestamp();
					List<string> list=Directory.GetDirectories(path).ToList();
					list.AddRange(Directory.GetFiles(path).ToList());
					foreach(string sel in list)
					{
						StorageInfo item=new StorageInfo();
					}
				}
			return res;
		}


		private static ulong GetTimeDiff(ulong past_time)
		{
			return GetTimestamp()-past_time;
		}

		private static ulong GetTimestamp()
		{
			return (ulong)Math.Floor(TimeSpan.FromTicks(DateTime.Now.Ticks).TotalMilliseconds);
		}


		private async void ScanSize_Files(string path)
		{
			if(Directory.Exists(path))
				foreach(FileInfo sel in new DirectoryInfo(path).GetFiles())
				{
					StorageInfo obj = new StorageInfo
					{
						Size=sel.Length,
						Name=sel.Name+"."+sel.Extension,
						BaseName=sel.Name,
						Extension=sel.Extension,
						Path=sel.FullName
					};
					Items.Add(obj);
					Size+=sel.Length;
				}
		}

		private async void ScanSize_Dirs(string path)
		{
			if(Directory.Exists(path))
				foreach(DirectoryInfo sel in new DirectoryInfo(path).GetDirectories())
					await Task.Run(()=>ScanSize_Files(path));
			_Complete=true;
		}



	}
}
