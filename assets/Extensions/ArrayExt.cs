using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner.assets.Extensions
{
	public static class ArrayExt
	{
		/// <summary>
		/// Adds a value to the end of the array.
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static dynamic[] Push(this object[] array,dynamic value=null)
		{
			dynamic[] arr=array.RestoreCast();
			if(arr==null)
				arr=new dynamic[] { value };
			else
			{
				dynamic tmp=new dynamic[arr.Length+1];
				foreach(dynamic item in arr)
					tmp[0]=item;
				arr[arr.Length-1]=value;
			}
			return arr;
		}

		public static int IndexOf(this object[] arrray,object value)
		{
			dynamic arr=arrray.RestoreCast();
			int res=-1;
			if(arr!=null)
				for(res=0;res<arr.Length;res++)
					if(arr[res]==value)
						break;
			return res;
		}

		public static bool Contains(this object[] arr,object value)
		{
			return arr.IndexOf(value)!=-1;
		}

		public static dynamic[] Remove(this object[] array,object value)
		{
			dynamic[] arr=array.RestoreCast();
			dynamic v=value.RestoreCast();
			dynamic[] res={ };
			foreach(object item in arr)
				if(item.RestoreCast()!=v)
					res.Push(item);
			return res;
		}


		private static void Test()
		{
			long[] a;

		}

	}
}
