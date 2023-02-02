using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrownfieldLibrary.Models;

namespace ConsoleUI
{
	public static class BillCustom
	{
		public static void BillCustomer(List<EnterModel> timeSheets, CustomerModel customer)
		{

			double totalHours = TimeSheetProcess.GetHoursWorksForCompany(timeSheets, customer.CustomerName);

			Console.WriteLine($"Simulating Sending email to {customer.CustomerName}");
			Console.WriteLine("Your bill is $" + (decimal)totalHours * customer.HourlyRateToBill + " for the hours worked.");
			Console.WriteLine();

		}
	}
}
