using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	/// <summary>
	/// Class for generating random numbers
	/// </summary>
	public class Random
	{
		public int Seed { get; }
		public List<object> Values { get; } = new List<object>();

		public Random(int seed = 0) 
		{
			Seed = seed;
		}

		public int Range(int min, int max)
		{
			System.Random r = new System.Random(Seed);
			int num = r.Next(min, max + 1);
			Values.Add(num);
			return num;
		}
		public float Range()
		{
			System.Random r = new System.Random(Seed);
			float num = r.Next(0, 100 + 1) / 100;
			Values.Add(num);
			return num;
		}
		public static int Range(int min, int max, int seed = 0)
		{
			System.Random r = new System.Random(seed);
			return r.Next(min, max + 1);
		}
		public static float Range(int seed = 0)
		{
			System.Random r = new System.Random(seed);
			return r.Next(0, 100 + 1) / 100;
		}
	}
}
