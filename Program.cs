using System;

namespace GeneratePasswrd
{
	class Program
	{
		const int DefaultLength = 16;
		const int DefaultNumberOfNonAlphanumericCharacters = 4;

		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine(PasswordGenerator.Generate(DefaultLength, DefaultNumberOfNonAlphanumericCharacters));
				Console.Read();
				return;
			}

			if (args.Length != 2
				|| !int.TryParse(args[0], out var length)
				|| !int.TryParse(args[1], out var n))
			{
				Console.WriteLine("Нужно определить длину и количество специальных символов. Ожидается два числовых аргумента.");
				return;
			}

			Console.WriteLine(PasswordGenerator.Generate(length, n));
			Console.Read();
		}
	}
}
