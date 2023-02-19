using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	public class Vector3
	{
		public float X { get; set; } = 0;
		public float Y { get; set; } = 0;
		public float Z { get; set; } = 0;

		public static Vector3 Zero => new Vector3(0.0f, 0.0f, 0.0f);
		public static Vector3 Random => new Vector3(Mathematics.Random.Range(0), Mathematics.Random.Range(0), Mathematics.Random.Range(0));
		public static Vector3 Max => new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		public static Vector3 Min => new Vector3(float.MinValue, float.MinValue, float.MinValue);

		public Vector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}
		public Vector3(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public static bool operator ==(Vector3 a, Vector3 b)
		{
			if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
				return true;
			else
				return false;
		}
		public static bool operator !=(Vector3 a, Vector3 b)
		{
			if (a.X != b.X || a.Y != b.Y || a.Z != b.Z)
				return true;
			else
				return false;
		}
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
		}
		public static Vector3 operator +(Vector3 a, int num)
		{
			return new Vector3(a.X + num, a.Y + num, a.Z + num);
		}
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
		}
		public static Vector3 operator -(Vector3 a, int num)
		{
			return new Vector3(a.X - num, a.Y - num, a.Z - num);
		}
		public static Vector3 operator ++(Vector3 a)
		{
			return new Vector3(a.X + 1, a.Y + 1, a.Z + 1);
		}
		public static Vector3 operator --(Vector3 a)
		{
			return new Vector3(a.X - 1, a.Y - 1, a.Z - 1);
		}
		public static Vector3 operator *(Vector3 a, Vector3 b)
		{
			return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
		}
		public static Vector3 operator *(Vector3 a, int num)
		{
			return new Vector3(a.X * num, a.Y * num, a.Z * num);
		}
		public static Vector3 operator /(Vector3 a, Vector3 b)
		{
			return new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
		}
		public static Vector3 operator /(Vector3 a, int num)
		{
			return new Vector3(a.X / num, a.Y / num, a.Z / num);
		}

		public Vector1 ToVector1()
		{
			return new Vector1(this.X);
		}
		public Vector2 ToVector2()
		{
			return new Vector2(this.X, this.Y);
		}

		public override string ToString()
		{
			return "(" + X + ";" + Y + ";" + Z + ")";
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
			return (int)(X * Y * Z);
		}
	}
}
