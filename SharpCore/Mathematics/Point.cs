using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	/// <summary>
	/// Class for defining X and Y coordinates (2D)
	/// </summary>
	[Serializable]
	public class Point : Vector2
	{
		public Point(float x, float y) : base(x, y)
		{ }
		public Point(int x, int y) : base(x, y)
		{ }

		public override string ToString()
		{
			return "(X:" + X + " Y:" + Y + ")";
		}
	}
}
