using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace VDCleaner
{
	public class Storage
	{

		public List<DriveInfo> Drives=new List<DriveInfo>();
		private Window WinIns;
		public AsyncStorage ASto;
		public Dictionary<string,List<StorageInfo>> Items=new Dictionary<string, List<StorageInfo>>();
		private static List<string> Loaded=new List<string>();
		private List<string> DriveNames=new List<string>();
		public static string DesktopPath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		public Storage(Window ins)
		{
			//Drives=DriveInfo.GetDrives();
			DriveInfo[] l=DriveInfo.GetDrives();
			WinIns=ins;
			WinIns.StorageControl.NodeMouseClick+=StorageControl_NodeMouseClick;
			foreach(DriveInfo d in l)
				if(d.IsReady)
				{
					Drives.Add(d);
					string n = d.Name;
					WinIns.StorageControl.Nodes.Add(n,n);
					DriveNames.Add(d.Name);
				}
		}

		private void StorageControl_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
		{
			Loaded.Clear();
			if(Directory.Exists(e.Node.Name))
				if(!Loaded.Contains(e.Node.Name))
				{
					if(DriveNames.Contains(e.Node.Name))
						ScanImplement(e.Node.Name,false,true);
					else
						ScanImplement(e.Node.Name,true);
					Loaded.Add(e.Node.Name);
				}
		}


		public void ScanImplement(string path=null,bool allow_size=false,bool allow_first=false)
		{
			if(path.CheckPath())
			{
				if(Directory.Exists(path))
				{
					DirectoryInfo d=new DirectoryInfo(path);
					WinIns.StorageControl.Nodes.Find(d.FullName,true)[0].Nodes.Clear();
					if(HasAccess(path))
					{
						
						if(!Loaded.Contains(d.FullName)&&!Loaded.Contains(path))
						{
							var obj = WinIns.StorageControl.Nodes.Find(d.FullName,true)[0];
							obj.Nodes.Clear();
							obj.Nodes.Add(d.FullName,d.Name);
							obj=WinIns.StorageControl.Nodes.Find(d.FullName,true)[0];
							if(allow_size)
								obj.Nodes.Add("Size:        "+GetSize(d.FullName).GetSize());
							obj.Nodes.Add("Path:        "+d.FullName);
							//Loaded.Add(d.FullName);
						}
						
						foreach(FileInfo f in d.GetFiles())
						{
							if(!Loaded.Contains(f.FullName))
							{
								var obj = WinIns.StorageControl.Nodes.Find(path,true)[0];
								obj.Nodes.Add(f.FullName,f.Name);
								obj=WinIns.StorageControl.Nodes.Find(f.FullName,true)[0];
								obj.Nodes.Add("Size:        "+GetSize(f.FullName).GetSize());
								obj.Nodes.Add("Path:        "+f.FullName);
								obj.Nodes.Add("Extension:   "+f.Extension);
							}
						}
						
						foreach(DirectoryInfo f in d.GetDirectories())
						{
							if(!Loaded.Contains(f.FullName))
							{
								var obj = WinIns.StorageControl.Nodes.Find(d.FullName,true)[0];
								//obj.Nodes.Clear();
								obj.Nodes.Add(f.FullName,f.Name);
								obj=WinIns.StorageControl.Nodes.Find(f.FullName,true)[0];
								if(allow_size)
									obj.Nodes.Add("Size:        "+GetSize(f.FullName).GetSize());
								obj.Nodes.Add("Path:        "+f.FullName);
								//Loaded.Add(f.FullName);
							}
						}


					}
				}
			}
		}


		public static string[] ScanDir(string path)
		{
			string[] res=null;
			if(path.CheckPath())
				if(Directory.Exists(path))
					res=path.CheckPath() ? Directory.GetDirectories(path) : null;
			return res;
		}

		public static long GetSize(string path)
		{
			long res=0;
			if(path.CheckPath())
			{
				if(File.Exists(path))
					res=new FileInfo(path).Length;
				else if(Directory.Exists(path))
				{
					DirectoryInfo d=new DirectoryInfo(path);
					if(HasAccess(path))
					{
						foreach(FileInfo sel in d.GetFiles())
							res+=sel.Length;
						foreach(DirectoryInfo sel in d.GetDirectories())
							if(HasAccess(sel.FullName))
								res+=GetSize(sel.FullName);
					}
				}
			}
			return res;
		}

		public static bool HasAccess(string path)
		{
			bool res=false;
			if(path.CheckPath())
			{
				if(Directory.Exists(path))
				{
					DirectorySecurity acl=null;
					try
					{
						acl=Directory.GetAccessControl(path);
					}
					catch{}
					if(acl!=null)
					{
						AuthorizationRuleCollection ar=acl.GetAccessRules(true,true,typeof(System.Security.Principal.SecurityIdentifier));
						int p=-1;
						if(ar!=null)
							foreach(FileSystemAccessRule r in ar)
								if(
									(FileSystemRights.Read & r.FileSystemRights)==FileSystemRights.Read || 
									(FileSystemRights.ListDirectory & r.FileSystemRights)==FileSystemRights.ListDirectory || 
									(FileSystemRights.ReadPermissions & r.FileSystemRights)==FileSystemRights.ReadPermissions ||
									(FileSystemRights.FullControl & r.FileSystemRights)==FileSystemRights.FullControl
									)
									if(r.AccessControlType==AccessControlType.Allow)
										p++;
						if(p>2)
							res=true;
					}
				}
			}
			return res;
		}

		public async void GenerateView()
		{
			//WinIns.StorageControl
			foreach(DriveInfo sel in Drives)
			{
				WinIns.StorageControl.Nodes.Add(sel.Name+"_NODE",sel.Name);
				//await Task.Run(()=>GenerateViewSpec(sel.Name,sel.Name+"_NODE"));
				GenerateViewSpec(sel.Name,sel.Name+"_NODE");
			}
		}

		private void GenerateViewSpec(string path,string pt)
		{
			if(path.CheckPath())
			{
				var tmp=WinIns.StorageControl.Nodes.Find(pt,true);
				if(tmp!=null)
					if(tmp.Length>0)
					{
						TreeNodeCollection nc = tmp[0].Nodes;
						if(File.Exists(path))
						{
							FileInfo f = new FileInfo(path);
							nc.Add(path+"_FILENODE",f.Name+"."+f.Extension);
							nc[path+"_FILENODE"].Nodes.Add("Size:      "+f.Length);
							nc[path+"_FILENODE"].Nodes.Add("Path:      "+f.FullName);
							nc[path+"_FILENODE"].Nodes.Add("Extension: "+f.Extension);
						}
						else if(Directory.Exists(path))
						{
							DirectoryInfo d = new DirectoryInfo(path);
							nc.Add(path+"_DIRNODE",d.Name);
							nc[path+"_DIRNODE"].Nodes.Add("----SIZE----:        "+GetSize(path));
							foreach(DirectoryInfo sel in d.GetDirectories())
							{
								string p = sel.FullName;
								//nc.Add(p+"_DIRNODE",d.Name);
								//nc[p+"_DIRNODE"].Nodes.Add("----SIZE----:        "+GetSize(p));
								GenerateViewSpec(p,p+"_DIRNODE");
								//await Task.Run(() => GenerateViewSpec(p,p+"_DIRNODE"));
							}
							foreach(FileInfo sel in d.GetFiles())
							{
								//await Task.Run(() => GenerateViewSpec(path,path+"_DIRNODE"));
								GenerateViewSpec(path,path+"_DIRNODE");
							}
						}
					}
			}
		}

		public async Task<long> AsyncGetSize(string path)
		{
			long res=0;
			if(path.CheckPath())
			{
				AsyncStorage obj=new AsyncStorage();
				obj.GetSizes(path);
				await Task.Run(()=>WaitForAsyncComplete(obj));
				res=obj.Size;
			}
			return res;
		}

		private void WaitForAsyncComplete(AsyncStorage obj)
		{
			while(!obj.Complete);
		}

		public static List<string> Scan(string path)
		{
			List<string>res=new List<string>();
			if(path.CheckPath())
				if(Directory.Exists(path))
				{
					DirectoryInfo d=new DirectoryInfo(path);
					foreach(FileInfo sel in d.GetFiles())
						res.Add(sel.FullName);
					foreach(DirectoryInfo sel in d.GetDirectories())
						res.Add(sel.FullName);
				}
			return res;
		}

		public static List<FileInfo> GetFiles(string path)
		{
			List<FileInfo>res=new List<FileInfo>();
			if(path.CheckPath())
				if(Directory.Exists(path))
				{
					DirectoryInfo d=new DirectoryInfo(path);
					foreach(FileInfo sel in d.GetFiles())
						res.Add(sel);
				}
			return res;
		}

		/// <summary>
		/// Moves a file into a directory.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="destination"></param>
		public static void Move(string source,string destination)
		{
			if(source.CheckPath())
			{
				if(!destination.CheckPath())
					Directory.CreateDirectory(destination);
				if(Directory.Exists(destination))
					if(File.Exists(source))
					{
						string nn=destination+"\\"+new FileInfo(source).Name;
						if(!File.Exists(nn))
						{
							File.Copy(source,nn,false);
							File.Delete(source);
						}
					}
			}
		}


		public static void CreateDirectories(FileInfo file,string destination)
		{
			if(file.Extension.CheckValue()&&destination.CheckPath())
			{
				string q=file.Extension.ToLower().Substring(1,file.Extension.Length-1);
				bool img=q=="png"||q=="jpg"||q=="jpeg"||q=="webp"||q=="gif"||q=="svg";
				bool doc=q=="doc"||q=="docx"||q=="pdf"||q=="xl"||q=="csv"||q=="ppt"||q=="txt"||q=="rtf"||q=="odt"||q=="tex"||q=="wpd"||q=="word"||q=="ixl"||q=="exl";
				bool video=q=="mp4"||q=="mov"||q=="mkv"||q=="m4a"||q=="asf"||q=="wma"||q=="wmv"||q=="wm"||q=="avi"||q=="ogg"||q=="m4a4";
				bool audio=q=="mp3"||q=="m4a";
				bool font=q=="ttf"||q=="oft";
				bool exe=q=="exe";
				bool code=q=="cs"||q=="php"||q=="js"||q=="json"||q=="html"||q=="css"||q=="py"||q=="cpp"||q=="sl"||q=="c";
				bool lnk=q=="lnk"||q=="shortcut";
				bool ini=q=="ini";
				bool obj=q=="obj"||q=="glb"||q=="3mf"||q=="mtl";
				DirectoryInfo d=new DirectoryInfo(destination);
				if(exe||lnk)
					Directory.CreateDirectory(d.FullName+"\\Programs");
				else
				{
					//Directory.CreateDirectory(d.FullName+"\\Files");
					//Directory.CreateDirectory(d.FullName+"\\Files\\"+q);
				}
				/*
				if(img||doc||video||audio||font||code||lnk||ini||lnk||obj)
				{
					Directory.CreateDirectory(d.FullName+"\\Files");
					Directory.CreateDirectory(d.FullName+"\\Files\\"+q);
				}
				*/
			}
		}

		public static string GetDirectory(FileInfo file)
		{
			string res=null;
			if(file.Extension.CheckValue())
			{
				string q=file.Extension.ToLower().Substring(1,file.Extension.Length-1);
				bool img=q=="png"||q=="jpg"||q=="jpeg"||q=="webp"||q=="gif"||q=="svg";
				bool doc=q=="doc"||q=="docx"||q=="pdf"||q=="xl"||q=="csv"||q=="ppt"||q=="txt"||q=="rtf"||q=="odt"||q=="tex"||q=="wpd"||q=="word"||q=="ixl"||q=="exl"||q=="info"||q=="nfo";
				bool video=q=="mp4"||q=="mov"||q=="mkv"||q=="m4a"||q=="asf"||q=="wma"||q=="wmv"||q=="wm"||q=="avi"||q=="ogg"||q=="m4a4";
				bool audio=q=="mp3"||q=="m4a";
				bool font=q=="ttf"||q=="oft";
				bool exe=q=="exe";
				bool code=q=="cs"||q=="php"||q=="js"||q=="json"||q=="html"||q=="css"||q=="py"||q=="cpp"||q=="sl"||q=="c";
				bool lnk=q=="lnk"||q=="shortcut";
				bool ini=q=="ini";
				bool obj=q=="obj"||q=="glb"||q=="3mf"||q=="mtl";
				bool arch=q=="zip"||q=="archive"||q=="rar"||q=="tor";
				if(exe||lnk)
					res="\\Programs";
				else
				{
					res="\\Files\\";
					if(img)
						res+="Images\\";
					else if(arch)
						res+="Compressed\\";
					else if(doc)
						res+="Documents\\";
					else if(video||audio)
					{
						res+="Media\\";
						if(video)
							res+="Videos\\";
						else
							res+="Audio\\";
					}
					else if(font)
						res+="Fonts\\";
					else if(code)
						res+="Programming\\";
					else if(obj)
						res+="3DObjects\\";
					else
						res+="Other\\";
					res+=q;
				}
				/*
				if(img||doc||video||audio||font||code||lnk||ini||lnk||obj)
					res="\\Files\\"+q;
				else if(exe)
					res="\\Programs";
				*/
			}
			return res;
		}







	}
}
