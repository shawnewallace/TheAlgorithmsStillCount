using System;
using System.Linq;
using System.Diagnostics;
using System.Text;

namespace DELEGATE_R_N_D
{
	public class Runner<T, TReturn>
	{
		public TReturn Invoke(Func<T, TReturn> method, T param)
		{
			return method(param);
		}
	}

	public static class Methods
	{
		public static string DoSomething(string value)
		{
			return value.ToUpper();
		}

		public static string DoSomethingElse(string value)
		{
			return new string(value.Reverse().ToArray());
		}

		public static string DoSomethingElseMore(string value)
		{
			return (DoSomething(DoSomethingElse(value)));
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting...");

			//DelegateComparison();
			FibonacciComparison();
			//ConcatComparison();

			Console.ReadLine();
		}

		private static void ConcatComparison()
		{
			var sw = new Stopwatch();
			string result = "";

			sw.Reset();
			sw.Start();
			var sb = new StringBuilder("Initial");
			sb.Append(" - Appended");
			result = sb.ToString();
			sw.Stop();
			Console.WriteLine("{0}, {1}", result, sw.ElapsedTicks);

			result = "";
			sw.Reset();
			sw.Start();
			result = "Initial" + " - Appended";
			sw.Stop();
			Console.WriteLine("{0}, {1}", result, sw.ElapsedTicks);

			result = "";
			sw.Reset();
			sw.Start();
			result = String.Format("{0}{1}", "Initial", " - Appended");
			sw.Stop();
			Console.WriteLine("{0}, {1}", result, sw.ElapsedTicks);
			
			sw.Reset();
			sw.Start();
			sb = new StringBuilder("Initial");
			for (int i = 0; i < 10; i++)
			{
				sb.Append(i.ToString());
			}
			result = sb.ToString();
			sw.Stop();
			Console.WriteLine("{0}, {1}", result, sw.ElapsedTicks);

			sw.Reset();
			sw.Start();
			result = "Initial";
			for (int i = 0; i < 10; i++)
			{
				result += i.ToString();
			}
			result = sb.ToString();
			sw.Stop();
			Console.WriteLine("{0}, {1}", result, sw.ElapsedTicks);

			sw.Reset();
			sw.Start();
			result = "Initial";
			for (int i = 0; i < 10; i++)
			{
				result = string.Format("{0}{1}", result, i.ToString());
			}
			result = sb.ToString();
			sw.Stop();
			Console.WriteLine("{0}, {1}", result, sw.ElapsedTicks);

		}

		private static void FibonacciComparison()
		{
			var sw = new Stopwatch();

			var fib = new Fib();

			double iterResult;
			double phiResult;
			for (var i = 1; i <= 50; i++)
			{
				sw.Reset();
				sw.Start();
				iterResult = fib.CalculateIteratively(i);
				sw.Stop();
				var iterTime = sw.ElapsedTicks;
				
				sw.Reset();
				sw.Start();
				phiResult = fib.Calculate(i);
				sw.Stop();
				var phiTime = sw.ElapsedTicks;

				//sw.Reset();
				//sw.Start();
				//fib.CalculateRecursively(i);
				//sw.Stop();
				var recurseResult = sw.ElapsedTicks;
				
				Console.WriteLine("Fib({0}) {1} : {2}, {3} : {4}"
				                  , i.ToString().PadLeft(3, '0')
				                  , iterResult.ToString().PadLeft(20)
				                  , iterTime.ToString().PadLeft(6)
				                  , phiResult.ToString().PadLeft(20)
				                  , phiTime.ToString().PadLeft(6));
			}

			Console.Write("...Done");
		}

		private static void DelegateComparison()
		{
			var sw = new Stopwatch();
			sw.Start();
			
			var x = new Runner<string, string>();

			Console.WriteLine(x.Invoke(Methods.DoSomething, "one"));
			Console.WriteLine(x.Invoke(Methods.DoSomething, "two"));
			Console.WriteLine(x.Invoke(Methods.DoSomethingElse, "one"));
			Console.WriteLine(x.Invoke(Methods.DoSomethingElseMore, "one two"));

			sw.Stop();
			Console.Write("...Done({0})", sw.ElapsedTicks);
			Console.ReadLine();

			sw.Reset();

			sw.Start();

			Console.WriteLine(Methods.DoSomething("one"));
			Console.WriteLine(Methods.DoSomething("two"));
			Console.WriteLine(Methods.DoSomethingElse("one"));
			Console.WriteLine(Methods.DoSomethingElseMore("one two"));

			sw.Stop();
			Console.WriteLine("...Done({0})", sw.ElapsedTicks);
		}
	}
}
