using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner.assets.Extensions
{
	public static class ObjectExt
	{
		/// <summary>
		/// Restores the original data-type it was set to.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public static dynamic RestoreCast(this object value)
		{
			return (dynamic)Convert.ChangeType(value,value.GetType());
			/*
			dynamic res=null;
			if(value!=null)
			{
				Type t=value.GetType();
				if(t.IsNumeric())
				{
					string n=t.Name.ToLower();
					if(n=="uint16")
						res=(ushort)value;
					else if(n=="uint32")
						res=(uint)value;
					else if(n=="uint64")
						res=(ulong)value;
					else if(n=="byte")
						res=(byte)value;
					else if(n=="int16")
						res=(short)value;
					else if(n=="int32")
						res=(int)value;
					else if(n=="int64")
						res=(long)value;
					else if(n=="single")
						res=(float)value;
					else if(n=="double")
						res=(double)value;
					else if(n=="sbyte")
						res=(sbyte)value;
					else
						throw new NotImplementedException("Unable to cast to original type due to lack of implementation.");
				}
				else if(t.Name.Contains("[]"))
				{
					string q=t.Name.Replace("[]","").ToLower();
					if(q=="uint16")
						res=(ushort[])value;
					else if(q=="uint32")
						res=(uint[])value;
					else if(q=="uint64")
						res=(ulong[])value;
					else if(q=="int16")
						res=(short[])value;
					else if(q=="int32")
						res=(int[])value;
					else if(q=="int64")
						res=(long[])value;
					else if(q=="single")
						res=(float[])value;
					else if(q=="double")
						res=(double[])value;
					else if(q=="char")
						res=(char[])value;
					else if(q=="string")
						res=(string[])value;
				}
			}
			return res;
			*/
		}
		/// <summary>
		/// Determines if the value is a numeric data-type.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsNumeric(this object value)
		{
			if(value!=null)
				return value.GetType().IsNumeric();
			return false;
		}

	}
}
