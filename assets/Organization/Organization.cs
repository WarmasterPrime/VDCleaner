using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner
{
	public class Organization
	{

		public static Dictionary<string,string> Methods = new Dictionary<string,string>
		{
			{"Default","Organizes files based on the file types and their categories."},
			{"Finances","Organizes document files based on their file names and created time."},
			{"Programs","Organizes programs and shortcuts and places them into a dedicated application/programs folder."},
			{"Images","Organizes image files based on the file type or name."}
		};


		public Window WinIns;

		public Organization(Window q)
		{
			if(q!=null)
			{
				WinIns=q;
				if(WinIns.SortingMethodControl!=null)
				{
					foreach(KeyValuePair<string,string> sel in Methods)
						WinIns.SortingMethodControl.Items.Add(sel.Key);
					WinIns.SortingMethodControl.SelectedValueChanged+=SortingMethodControl_SelectedValueChanged;
					WinIns.SortingMethodControl.SelectedIndex=0;
					WinIns.OrgInfoTextControl.MaximumSize=new System.Drawing.Size(WinIns.OrgInfoControl.Size.Width-5,WinIns.OrgInfoControl.Size.Height-5);
				}
			}
		}

		public void SortingMethodControl_SelectedValueChanged(object sender,EventArgs e)
		{
			if(WinIns!=null)
			{
				string txt=WinIns.SortingMethodControl.SelectedItem.ToString();
				WinIns.OrgInfoTextControl.Text=Methods.ContainsKey(txt) ? Methods[txt] : "ERROR";
			}
		}

		public string GetSelection()
		{
			string res=null;
			if(WinIns!=null)
				res=WinIns.SortingMethodControl.SelectedItem.ToString().CheckValue() ? WinIns.SortingMethodControl.SelectedItem.ToString() : null;
			return res;
		}




	}
}
