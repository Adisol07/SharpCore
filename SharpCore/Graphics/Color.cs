using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Graphics
{
	public class Color
	{
		public byte A { get; set; } = 0;
		public byte R { get; set; } = 0;
		public byte G { get; set; } = 0;
		public byte B { get; set; } = 0;

		public static Color Transparent => new Color(0, 0, 0, 0);
		public static Color White => new Color(255, 255, 255, 255);
		public static Color Black => new Color(255, 0, 0, 0);

		public Color()
		{ }
		public Color(byte a, byte r, byte g, byte b)
		{
			A = a;
			R = r;
			G = g;
			B = b;
		}
		public Color(byte r, byte g, byte b)
		{
			A = 255;
			R = r;
			G = g;
			B = b;
		}

		public Color FromiColor(iColor color)
		{
			return new Color((byte)color.A, (byte)color.R, (byte)color.G, (byte)color.B);
		}
		public iColor ToiColor()
		{
			return new iColor(A, R, G, B);
		}

		public Color FromARGB(byte a, byte r, byte g, byte b)
		{
			return new Color(a, r, g, b);
		}
		public Color FromRGB(byte r, byte g, byte b)
		{
			return new Color(255, r, g, b);
		}
		public Color FromSystem(System.Drawing.Color color)
		{
			return new Color(color.A, color.R, color.G, color.B);
		}

		public static bool operator ==(Color a, Color b)
		{
			if (a.A == b.A && a.R == b.R && a.G == b.G && a.B == b.B)
				return true;
			else
				return false;
		}
		public static bool operator !=(Color a, Color b)
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
