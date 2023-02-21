using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Graphics
{
	/// <summary>
	/// Class for making aRGB unlimited color
	/// </summary>
	[Serializable]
	public class iColor
	{
		public int A { get; set; } = 0;
		public int R { get; set; } = 0;
		public int G { get; set; } = 0;
		public int B { get; set; } = 0;

		public static iColor Transparent => new iColor(0, 0, 0, 0);
		public static iColor White => new iColor(255, 255, 255, 255);
		public static iColor Black => new iColor(255, 0, 0, 0);

		public iColor()
		{ }
		public iColor(int a, int r, int g, int b)
		{
			A = a;
			R = r;
			G = g;
			B = b;
		}
		public iColor(int r, int g, int b)
		{
			A = 255;
			R = r;
			G = g;
			B = b;
		}

		public iColor FromColor(Color color)
		{
			return new iColor(color.A, color.R, color.G, color.B);
		}
		public Color ToColor()
		{
			return new Color((byte)Math.Max(A, 255), (byte)Math.Max(R, 255), (byte)Math.Max(G, 255), (byte)Math.Max(B, 255));
		}

		public iColor FromARGB(byte a, byte r, byte g, byte b)
		{
			return new iColor(a, r, g, b);
		}
		public iColor FromRGB(byte r, byte g, byte b)
		{
			return new iColor(255, r, g, b);
		}
		public iColor FromSystem(System.Drawing.Color color)
		{
			return new iColor(color.A, color.R, color.G, color.B);
		}

		public static bool operator ==(iColor a, iColor b)
		{
			if (a.A == b.A && a.R == b.R && a.G == b.G && a.B == b.B)
				return true;
			else
				return false;
		}
		public static bool operator !=(iColor a, iColor b)
		{
			if (a.A != b.A || a.R != b.R || a.G != b.G || a.B != b.B)
				return true;
			else
				return false;
		}

		public override string ToString()
		{
			return "(" + A + ";" + R + ";" + G + ";" + B + ")";
		}
		public override bool Equals(object obj)
		{
			bool result = false;

			if (ReferenceEquals(this, obj))
			{
				result = true;
			}

			if (ReferenceEquals(obj, null))
			{
				result = false;
			}

			return result;
		}
		public override int GetHashCode()
		{
			return (int)(A * R * G * B);
		}
	}
}
