using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	/// <summary>
	/// Base class for defining X and Y values (2D)
	/// </summary>
	[Serializable]
	public class Vector2
	{
		public float X { get; set; } = 0;
		public float Y { get; set; } = 0;

		public static Vector2 Zero => new Vector2(0.0f, 0.0f);
		public static Vector2 Random => new Vector2(Mathematics.Random.Range(0), Mathematics.Random.Range(0));
		public static Vector2 Max => new Vector2(float.MaxValue, float.MaxValue);
		public static Vector2 Min => new Vector2(float.MinValue, float.MinValue);

		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
		}
		public Vector2(int x, int y)
		{
			X = x;
			Y = y;
		}

		public static bool operator ==(Vector2 a, Vector2 b)
		{
			if (a.X == b.X && a.Y == b.Y)
				return true;
			else
				return false;
		}
		public static bool operator !=(Vector2 a, Vector2 b)
		{
			if (a.X != b.X || a.Y != b.Y)
				return true;
			else
				return false;
		}
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.X + b.X, a.Y + b.Y);
		}
		public static Vector2 operator +(Vector2 a, int num)
		{
			return new Vector2(a.X + num, a.Y + num);
		}
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.X - b.X, a.Y - b.Y);
		}
		public static Vector2 operator -(Vector2 a, int num)
		{
			return new Vector2(a.X - num, a.Y - num);
		}
		public static Vector2 operator ++(Vector2 a)
		{
			return new Vector2(a.X + 1, a.Y + 1);
		}
		public static Vector2 operator --(Vector2 a)
		{
			return new Vector2(a.X - 1, a.Y - 1);
		}
		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			return new Vector2(a.X * b.X, a.Y * b.Y);
		}
		public static Vector2 operator *(Vector2 a, int num)
		{
			return new Vector2(a.X * num, a.Y * num);
		}
		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			return new Vector2(a.X / b.X, a.Y / b.Y);
		}
		public static Vector2 operator /(Vector2 a, int num)
		{
			return new Vector2(a.X / num, a.Y / num);
		}

		public Vector1 ToVector1()
		{
			return new Vector1(this.X);
		}
		public Vector3 ToVector3()
		{
			return new Vector3(this.X, this.Y, 0.0f);
		}

		public override string ToString()
		{
			return "(" + X + ";" + Y + ")";
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
			return (int)(X * Y);
		}
	}
}
