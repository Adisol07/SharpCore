using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCore.Mathematics
{
	public class Random
	{
		public int Seed { get; }

		public Random(int seed = 0) 
		{
			Seed = seed;
		}

		public int Range(int min, int max)
		{
			System.Random r = new System.Random(Seed);
			return r.Next(min, max + 1);
		}
		public float Range()
		{
			System.Random r = new System.Random(Seed);
			return r.Next(0, 100 + 1) / 100;
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
