using System;

namespace Algorithms.Lib
{
	public class Fib
	{
		public double Phi
		{
			get {
				return (_phi ?? (_phi  = (1 + Math.Sqrt(5)) / 2)).Value; 
				//return 1.618033989;
			}
		}
	    private double? _phi;

	    public double CalculateIteratively(int n)
		{
			if (n < 2) return n;

			double fib = 0;
            double a = 0;
            double b = 1;

			for (int i = 1; i < n; i++)
			{
				fib = a + b;
				a = b;
				b = fib;
			}

			return fib;
		}

		public double CalculateRecursively(int n)
		{
			if (n < 2) return n;

			return CalculateRecursively(n - 1) + CalculateRecursively(n - 2);
		}

		public double Calculate(int n)
		{
			return Math.Floor((Math.Pow(Phi, n) - Math.Pow(1.0 - Phi, n))/Math.Sqrt(5));
		}
	}
}
