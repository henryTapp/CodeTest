using CodeTest.WordHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodeTest
{
	internal class Program
	{
		public static bool IsVerbose { get; internal set; }

		internal static void Main(string[] args)
		{
			var words = new List<string>
			{
				"Tar", "Elbow", "Anna", "Rat", "Dormitory", "Racecar", "Silent", "Silence",
				"Listen", "The Eyes", "God", "Nana", "They See!", "Coffee Hit?", "Old West Action",
				"The Office", "Clint Eastwood", "Dog"
			};

			int iterations = 100;

			Console.WriteLine("Benchmarking two implementations of IWordChecker with 100 iterations.");
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine($"Lazy implementation - {Benchmark(() => WordChecker.CheckWords(new LazyWordHelper(), words), iterations).TotalMilliseconds / iterations}ms per run.");
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine($"Fast implementation - {Benchmark(() => WordChecker.CheckWords(new FastWordHelper(), words), iterations).TotalMilliseconds / iterations}ms per run.");
			Console.ReadKey();
		}

		internal static TimeSpan Benchmark(Action action, int iterations)
		{
			Stopwatch stopwatch = new();

			IsVerbose = true;
			action.Invoke();
			Console.WriteLine(Environment.NewLine);
			IsVerbose = false;

			stopwatch.Start();

			for (int i = 0; i < iterations; i++)
			{
				action.Invoke();
			}

			stopwatch.Stop();

			return stopwatch.Elapsed;
		}
	}
}
