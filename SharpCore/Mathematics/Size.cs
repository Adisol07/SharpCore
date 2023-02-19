using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	public class Size : Vector2
	{
		public int Width => (int)X;
		public int Height => (int)Y;

		public Size(int width, int height) : base(width, height)
		{ }
	}
}
