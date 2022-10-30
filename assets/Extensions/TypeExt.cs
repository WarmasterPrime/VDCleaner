using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner.assets.Extensions
{
	public static class TypeExt
	{

		private static readonly string[] NumericDataTypes={
			"SByte","Byte",
			"UInt16","UInt32","UInt64",
			"Int16","Int32","Int64",
			"Single","Double"
		};



		/// <summary>
		/// Checks if the data-type is numeric.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsNumeric(this Type value)
		{
			if(value.IsPrimitive)
				return NumericDataTypes.Contains(value.Name);
			return false;
		}

	}
}
