using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	/// <summary>
	/// Class for defining Width, Height and Depth scale (3D)
	/// </summary>
	[Serializable]
	public class Scale : Vector3
	{
		public float Width => (int)X;
		public float Height => (int)Y;
		public float Depth => (int)Z;

		public Scale(float width, float height, float depth) : base(width, height, depth)
		{ }
		public Scale(int width, int height, int depth) : base(width, height, depth)
		{ }

		public override string ToString()
		{
			return "(Width:" + Width + " Height:" + Height + " Depth:" + Depth + ")";
		}
	}
}
