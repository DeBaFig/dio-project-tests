using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
	public class Calculator
	{
		private List<string> listCalculations = new List<string>();
		private void AddItemToLog(int num1, int num2, int result, string method)
		{
			this.listCalculations.Add($"{num1}{method}{num2}={result} - Feito as: {DateTime.Now}");
		}

		public List<string> GetLogs(int numberLogs)
		{
			return this.listCalculations.TakeLast(numberLogs).ToList();
		}
		public int Sum(int num1, int num2)
		{
			var result = num1 + num2;
			AddItemToLog(num1, num2, result, "+");
			return result;
		}
		public int Subtract(int num1, int num2)
		{
			var result = num1 - num2;
			AddItemToLog(num1, num2, result, "-");
			return result;
		}
		public int Divide(int num1, int num2)
		{
			if (num2 > 0)
			{
				var result = num1 + num2;
				AddItemToLog(num1, num2, result, "/");
				return result;
			}
			AddItemToLog(num1, num2, 0, "/");
			return 0;
		}
		public int Multiply(int num1, int num2)
		{
			var result = num1 * num2;
			AddItemToLog(num1, num2, result, "*");
			return num1 * num2;
		}

		public void ShowResults(int num1, int num2)
		{
			Console.WriteLine("-----Resultados-----");
			Console.WriteLine("-----Soma-----");
			Console.WriteLine($"{num1}+{num2}={Sum(num1, num2)}");
			Console.WriteLine("-----Subtração-----");
			Console.WriteLine($"{num1}-{num2}={Subtract(num1, num2)}");
			Console.WriteLine("-----Divisão-----");
			Console.WriteLine($"{num1}/{num2}={Divide(num1, num2)}");
			Console.WriteLine("-----Multiplicação-----");
			Console.WriteLine($"{num1}*{num2}={Multiply(num1, num2)}");

		}
	}
}
