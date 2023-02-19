using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	public class Vector1
	{
		public float X { get; set; } = 0.0f;

		public static Vector1 Zero => new Vector1(0.0f);
		public static Vector1 Random => new Vector1(Mathematics.Random.Range(0));
		public static Vector1 Max => new Vector1(float.MaxValue);
		public static Vector1 Min => new Vector1(float.MinValue);

		public Vector1(float x)
		{
			X = x;
		}
		public Vector1(int x)
		{
			X = x;
		}

		public static bool operator ==(Vector1 a, Vector1 b)
		{
			if (a.X == b.X)
				return true;
			else
				return false;
		}
		public static bool operator !=(Vector1 a, Vector1 b)
		{
			if (a.X != b.X)
				return true;
			else
				return false;
		}
		public static Vector1 operator +(Vector1 a, Vector1 b)
		{
			return new Vector1(a.X + b.X);
		}
		public static Vector1 operator +(Vector1 a, int num)
		{
			return new Vector1(a.X + num);
		}
		public static Vector1 operator -(Vector1 a, Vector1 b)
		{
			return new Vector1(a.X - b.X);
		}
		public static Vector1 operator -(Vector1 a, int num)
		{
			return new Vector1(a.X - num);
		}
		public static Vector1 operator ++(Vector1 a)
		{
			return new Vector1(a.X + 1);
		}
		public static Vector1 operator --(Vector1 a)
		{
			return new Vector1(a.X - 1);
		}
		public static Vector1 operator *(Vector1 a, Vector1 b)
		{
			return new Vector1(a.X * b.X);
		}
		public static Vector1 operator *(Vector1 a, int num)
		{
			return new Vector1(a.X * num);
		}
		public static Vector1 operator /(Vector1 a, Vector1 b)
		{
			return new Vector1(a.X / b.X);
		}
		public static Vector1 operator /(Vector1 a, int num)
		{
			return new Vector1(a.X / num);
		}

		public Vector2 ToVector2()
		{
			return new Vector2(this.X, 0.0f);
		}
		public Vector3 ToVector3()
		{
			return new Vector3(this.X, 0.0f, 0.0f);
		}

		public override string ToString()
		{
			return "(" + X + ")";
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
			return (int)(X);
		}
	}
}
