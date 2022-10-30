using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using VDCleaner.assets.Extensions;

namespace VDCleaner
{
	public static class StringExtension
	{

		private static string[] ImageExtensions={
			"jpeg","jpg","bmp","gif","png","svg","raw","heic","webp"
		};

		/// <summary>
		/// Checks the string for its validity.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool CheckValue(this string value)
		{
			bool res=false;
			if(!string.IsNullOrEmpty(value))
				res=value.Trim().Length>0;
			return res;
		}
		/// <summary>
		/// Checks if the string value references an existing system file path.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool CheckPath(this string value)
		{
			bool res=false;
			if(value.CheckValue())
				res=Directory.Exists(value)||File.Exists(value);
			return res;
		}
		/// <summary>
		/// Checks if the string value references an existing file path.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsFile(this string value)
		{
			if(value.CheckValue())
				return File.Exists(value);
			return false;
		}
		/// <summary>
		/// Checks if the string value references an existing directory path.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsDir(this string value)
		{
			if(value.CheckValue())
				return Directory.Exists(value);
			return false;
		}
		/// <summary>
		/// Inserts a substring value into the string value at a specified point.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="sub"></param>
		/// <param name="pl"></param>
		/// <returns></returns>
		public static string Inserter(this string value,string sub,int pl)
		{
			string v="";
			if(sub.CheckValue())
			{
				int i=0;
				int c=0;
				while(i<value.Length)
				{
					if(c==pl)
					{
						c=0;
						v+=sub;
					}
					v+=value[i];
					c++;
					i++;
				}
			}
			return v;
		}
		/// <summary>
		/// Repeats a given string value a specified number of times.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static string Repeat(this string value,int length)
		{
			string str=value;
			if(value.CheckValue()&&length>0)
				for(int i=0;i<length;i++)
					str+=value;
			return str;
		}
		/// <summary>
		/// Capitalizes words.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string Capitalize(this string value,FilterFlags option=FilterFlags.None)
		{
			string str=value;
			if(value.CheckValue())
				if(Regex.IsMatch(value,"[\\sA-Za-z0-9]+"))
				{
					bool was_space=true;
					foreach(char c in value)
					{
						if(Regex.IsMatch(c.ToString(),"[a-z]"))
							if(was_space)
								str+=(char)(c-32);
						else
							str+=c;
						was_space=Regex.IsMatch(c.ToString(),"[^A-z]");
					}
				}
			return str;
		}

		public static bool IsImageFile(this string value)
		{
			if(value.IsFile())
				return ImageExtensions.Contains(Path.GetExtension(value));
			return false;

		}

	}
}
