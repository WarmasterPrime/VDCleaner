using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace VDCleaner
{
	public partial class Window:Form
	{
		private static string Version="0.0.0.0";
		public Storage StoIns;
		public Network NetworkIns;
		public Organization OrgIns;
		private int ReC=0;
		public Window()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender,EventArgs e)
		{
			StoIns=new Storage(this);
			NetworkIns=new Network();
			versionValueToolStripMenuItem.Text=Version;
			OrgIns=new Organization(this);
			UpdateDriveStorage();
			UpdateNetwork();
		}

		public void UpdateNetwork()
		{
			NetworkControl.Nodes.Add("IPv4:       "+NetworkIns.IPv4);
			NetworkControl.Nodes.Add("MAC:        "+NetworkIns.MAC);
			NetworkControl.Nodes.Add("Host Name:  "+NetworkIns.HostName);
			NetworkControl.Nodes.Add("NetInterfaces","NICs");
			foreach(NetworkInterface sel in NetworkIns.Interfaces)
			{
				NetworkControl.Nodes["NetInterfaces"].Nodes.Add(sel.Name,sel.Name);
				NetworkControl.Nodes["NetInterfaces"].Nodes[sel.Name].Nodes.Add("Name:         "+sel.Name);
				NetworkControl.Nodes["NetInterfaces"].Nodes[sel.Name].Nodes.Add("Description:  "+sel.Description);
				NetworkControl.Nodes["NetInterfaces"].Nodes[sel.Name].Nodes.Add("Status:       "+sel.OperationalStatus.ToString());
				NetworkControl.Nodes["NetInterfaces"].Nodes[sel.Name].Nodes.Add("Speed:        "+sel.Speed.GetNetSize());
			}
			NetworkControl.Nodes["NetInterfaces"].Expand();
		}

		public void UpdateDriveStorage()
		{
			DriveTabControl.Controls.Clear();
			int w = DriveTabControl.Width;
			int h = DriveTabControl.Height;
			int i = 1;
			Button btn = new Button();
			btn.BackColor=Color.Black;
			btn.ForeColor=Color.White;
			btn.Text="↺";
			btn.Size=new Size(new Point(14));
			btn.Width=35;
			btn.Height=35;
			btn.FlatStyle=FlatStyle.Flat;
			btn.Left=DriveTabControl.Width-btn.Width;
			btn.Click+=DriveRefresh_Click;
			btn.Show();
			DriveTabControl.Controls.Add(btn);
			foreach(DriveInfo sel in StoIns.Drives)
			{
				ProgressBar obj = new ProgressBar();
				obj.Value=(int)((((double)sel.TotalSize-(double)sel.AvailableFreeSpace)/(double)sel.TotalSize)*100);
				obj.Width=w;
				obj.Height=h/20;
				obj.Top=i*(obj.Height+40);
				obj.Minimum=0;
				obj.Maximum=100;
				obj.Style=System.Windows.Forms.ProgressBarStyle.Continuous;
				obj.Show();
				Label la = new Label();
				la.Text="Name:\t\t"+sel.Name+"\nUsed:\t\t"+obj.Value.ToString()+"%\n";
				la.Show();
				la.Top=i*(obj.Height+40)-30;
				la.Height=40;
				DriveTabControl.Controls.Add(obj);
				DriveTabControl.Controls.Add(la);
				i++;
			}
			DriveTabControl.Show();
			DriveTabControl.Update();
			AutoRefresh();
		}

		private async void AutoRefresh()
		{
			if(ReC==0)
			{
				await Task.Delay(1000);
				if(AutoRefreshCheckbox.Checked&&ReC<1)
				{
					ReC++;
					if(ReC==1)
					{
						ReC--;
						UpdateDriveStorage();
					}
				}
			}
		}

		private void DriveRefresh_Click(object sender,EventArgs e)
		{
			UpdateDriveStorage();
		}

		private void checkBox1_CheckedChanged(object sender,EventArgs e)
		{
			if(AutoRefreshCheckbox.Checked)
				AutoRefresh();
		}

		private void OrganizeBtn_Click(object sender,EventArgs e)
		{
			if(OrganizerTargetPathInput.Text.CheckPath())
			{
				List<FileInfo> l = Storage.GetFiles(OrganizerTargetPathInput.Text);
				List<string> ext=new List<string>();
				DirectoryInfo md=new DirectoryInfo(OrganizerTargetPathInput.Text);
				foreach(FileInfo sel in l)
				{
					if(!ext.Contains(sel.Extension.ToLower()))
					{
						Storage.CreateDirectories(sel,md.FullName);
						ext.Add(sel.Extension.ToLower());
					}
					Storage.Move(sel.FullName,md.FullName+Storage.GetDirectory(sel));
					OrganizerLabelStatus.Text="OPERATION COMPLETE!";
					OrganizerLabelStatus.ForeColor=Color.LightGreen;
					ResetSC();
					//Storage.Move(sel.FullName,md.FullName+"\\"+sel.Extension.ToLower());
				}
			}
		}

		private async void ResetSC()
		{
			await Task.Delay(3000);
			OrganizerLabelStatus.ForeColor=Color.Orange;
			OrganizerLabelStatus.Text="Ready To Run...";
		}

		private void OpenFolderBrowserDialog_Click(object sender,EventArgs e)
		{
			if(OrganizerTargetPathInput.Text.CheckPath())
				FolderBrowserDialog.SelectedPath=OrganizerTargetPathInput.Text;
			else
				FolderBrowserDialog.SelectedPath=Storage.DesktopPath;
			FolderBrowserDialog.ShowNewFolderButton=true;
			FolderBrowserDialog.ShowDialog();
			OrganizerTargetPathInput.Text=FolderBrowserDialog.SelectedPath;
			UpdateItemList();
		}

		private void UpdateItemList(object sender=null,EventArgs e=null)
		{
			DirItemListControl.Items.Clear();
			if(OrganizerTargetPathInput.Text.CheckPath())
			{
				foreach(FileInfo sel in Storage.GetFiles(OrganizerTargetPathInput.Text))
					DirItemListControl.Items.Add(sel.Name);
				if(DirItemListControl.Items.Count==0)
					DirItemListControl.Items.Add("[NO FILES FOUND]");
			}
			else
				DirItemListControl.Items.Add("[PATH DOES NOT EXISTS]");
		}

		private void ExitApplication_Click(object sender,EventArgs e)
		{
			Application.Exit();
		}

		private void label2_Click(object sender,EventArgs e)
		{

		}
	}
}
