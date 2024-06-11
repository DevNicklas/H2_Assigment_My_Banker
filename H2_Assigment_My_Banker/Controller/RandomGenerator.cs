using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Controller
{
	internal class RandomGenerator
	{
		private readonly Random _random = new Random();

		public string GenerateNumbers(byte length)
		{
			IEnumerable<string> numbers = Enumerable.Range(0, length).Select(_ => _random.Next(0, 10).ToString());
			return string.Join("", numbers);
		}

		public string GetRandomPrefix(List<string> prefixes)
		{
			if (prefixes == null || prefixes.Count == 0)
				throw new ArgumentException("Prefix list is null or empty.");

			int randomIndex = _random.Next(0, prefixes.Count);
			return prefixes[randomIndex];
		}
	}
}
