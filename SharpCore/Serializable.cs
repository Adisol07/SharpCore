using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace SharpCore
{
	/// <summary>
	/// Class for making serializable objects (have '[System.Serializable]' on top of class)
	/// </summary>
	[Serializable]
	public class Serializable
	{
		public virtual void Prepare() { }
		public void Serialize(string path, SerializeTypes type = SerializeTypes.Binary)
		{
			Prepare();
			if (type == SerializeTypes.Binary)
			{
				BinaryFormatter formatter = new BinaryFormatter();
				FileStream stream = new FileStream(path, FileMode.Create);
				formatter.Serialize(stream, this);
				stream.Close();
			}
		}
		public static dynamic Deserialize(string path, SerializeTypes type = SerializeTypes.Binary)
		{
			object result = null;

			if (!File.Exists(path))
				throw new FileNotFoundException(path);

			if (type == SerializeTypes.Binary)
			{
				BinaryFormatter formatter = new BinaryFormatter();
				FileStream stream = new FileStream(path, FileMode.Open);
				result = formatter.Deserialize(stream);
				stream.Close();
			}

			return result;
		}
	}
	public enum SerializeTypes
	{
		Binary = 0,
	}
}
