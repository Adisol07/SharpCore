using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	/// <summary>
	/// Class for defining X, Y and Z coordinates (3D)
	/// </summary>
	[Serializable]
	public class Position : Vector3
	{
		public Position(int x, int y, int z) : base(x, y, z)
		{ }

		public override string ToString()
		{
			return "(X:" + X + " Y:" + Y + " Z:" + Z + ")";
		}
	}
}
