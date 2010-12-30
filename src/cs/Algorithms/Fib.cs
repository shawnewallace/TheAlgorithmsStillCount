using System;

namespace Algorithms
{
	public class Fib
	{
		public double Phi
		{
			get {
				//return phi ?? (phi  = (1 + Math.Sqrt(5)) / 2); 
				return 1.618033989;
			}
		}

		public double CalculateIteratively(int n)
		{
			if (n == 0 || n == 1) return n;

			var fib = 0;
			int a = 0;
			int b = 1;

			for (int i = 2; i <= n; i++)
			{
				fib = a + b;
				a = b;
				b = fib;
			}

			return fib;
		}

		public double CalculateRecursively(int n)
		{
			if (n == 0 || n == 1) return n;

			return CalculateRecursively(n - 1) + CalculateRecursively(n - 2);
		}

		public double Calculate(int n)
		{
			return Math.Floor((Math.Pow(Phi, n) - (1.0 - Phi))/Math.Sqrt(5));
		}
	}
}
