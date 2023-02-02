using BrownfieldLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	public static class PayEmp
	{
		public static void PayEmployee(List<EnterModel> timeSheets, EmployeeModel employee)
		{
			decimal totalPay = TimeSheetProcess.CalculatePay(timeSheets, employee);
			Console.WriteLine($"You will get paid ${totalPay} for your time.");
			Console.WriteLine();

		}
	}
}
