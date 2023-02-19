using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	public class Point : Vector2
	{
		public Point(float x, float y) : base(x, y)
		{ }
		public Point(int x, int y) : base(x, y)
		{ }
	}
}
