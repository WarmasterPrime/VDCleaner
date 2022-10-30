using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner
{
	public static class StorageMeasurementsExtension
	{

		private static readonly string[] Units=
		{
			"KB",
			"MB",
			"GB",
			"TB",
			"PB"
		};

		private static readonly string[] NetUnits=
		{
			"kbps",
			"mbps",
			"gbps",
			"tbps",
			"pbps"
		};

		public static string GetSize(this long value)
		{
			string res="";
			long i=1000;
			//long value=q/8;
			foreach(string unit in Units)
			{
				if(value>=i)
				{
					long calc=i*1000;
					if(value<calc)
					{
						double n=Math.Floor((double)((double)value/i)*100)/100;
						string num=n.ToString();
						res=num+" "+unit;
						break;
					}
				}
				else
					break;
				i*=1000;
			}
			return res;
		}

		public static string GetNetSize(this long value)
		{
			string res="";
			long i=1000;
			foreach(string unit in NetUnits)
			{
				if(value>=i)
				{
					long calc=i*1000;
					if(value<calc)
					{
						double n=Math.Floor((double)((double)value/i)*100)/100;
						string num=n.ToString();
						res=num+" "+unit;
						break;
					}
				}
				else
					break;
				i*=1000;
			}
			return res;
		}

	}
}
