using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	/// <summary>
	/// Class for defining Width and Height size (2D)
	/// </summary>
	[Serializable]
	public class Size : Vector2
	{
		public int Width => (int)X;
		public int Height => (int)Y;

		public Size(int width, int height) : base(width, height)
		{ }

		public override string ToString()
		{
			return "(Width:" + Width + " Height:" + Height + ")";
		}
	}
}
