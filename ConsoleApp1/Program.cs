using SharpCore;
using SharpCore.Mathematics;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User user = new User();
			user.Name = "User1";
			user.Password = "Us@r1";
			user.Position = new Position(69,420,0);
			user.Serialize("./user.bin", SerializeTypes.Binary);

			User desUser = new User();
			desUser = Serializable.Deserialize("./user.bin", SerializeTypes.Binary);
			Console.WriteLine(desUser.Name + "-" + desUser.Password + "-" + desUser.Position?.ToString());

			Console.ReadKey();
		}
	}

	[Serializable]
	class User : Serializable
	{
		public string? Name { get; set; }
		public string? Password { get; set; }
		public Position? Position { get; set; }
	}
}