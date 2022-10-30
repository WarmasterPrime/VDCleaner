using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner.assets.Extensions
{
	[Flags]
	public enum FilterFlags
	{
		None=0x00,
		Word=0x1,
		Sentence=0x2,
		Once=0x4,
		Number=0x8,
		Letter=0x10,
		Symbol=0x20,
		Keyboard=0x40,
		Extended=0x100
	}
}
