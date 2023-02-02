using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrownfieldLibrary.Models;

namespace ConsoleUI
{
	public static class LoadTime
	{
		public static List<EnterModel> LoadTimeSheets()
		{
			List<EnterModel> output = new List<EnterModel>();
			string enterMoreTimeSheet = "";

			if(enterMoreTimeSheet.ToLower() == "yes")
			{
				Console.WriteLine("Enter what you did: ");
				string workDone = Console.ReadLine();
				Console.WriteLine("How long did you do it for: ");
				string rawTimeWorked = Console.ReadLine();
				double hoursWorked;

				while (double.TryParse(rawTimeWorked, out hoursWorked) == false)
				{
					Console.WriteLine();
					Console.WriteLine("Invalid number given");
					Console.WriteLine("How long did you do it for: ");
					rawTimeWorked = Console.ReadLine();
				}

				EnterModel timesheet = new EnterModel();
				timesheet.HoursWorked = hoursWorked;
				timesheet.WorkDone = workDone;
				output.Add(timesheet);

				Console.WriteLine("Do you want to enter more time (yes/no): ");
				enterMoreTimeSheet = Console.ReadLine();
			}

			Console.WriteLine();

			return output;
		}
	}
}
