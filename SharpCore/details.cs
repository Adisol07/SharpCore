using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore
{
	public static class Details
	{
		public static string Version => "1.0.0";
		public static string Snapshot => "000";
		public static string FullVersion => Version + "-" + Snapshot;
		public static string CountVersion => "1";
		public static string OneDigitVersion => "1";
	}
}
