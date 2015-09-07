using System;

namespace TareaCalculadora
{
	public class Calculadora
	{
		private double numA, numB;

		public Calculadora (int a, int b)
		{
			numA = a;
			numB = b;
		}

		public double Suma()
		{
			return numA + numB;
		}

		public double Resta()
		{
			return numA - numB;
		}

		public double Mult()
		{
			return numA * numB;
		}

		public double Divi()
		{
			return numA / numB;
		}

		public double Expon()
		{
			return Math.Pow (numA, numB);
		}

		public double Raiz()
		{
			return Math.Sqrt (numA);
		}

		public double Factorial()
		{
			double Acum = 0;
			for (int i = 0; i < numA; i++) {
				Acum += i;
			}

			return Acum;
		}
	}
}

