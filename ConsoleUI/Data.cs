using BrownfieldLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrownfieldLibrary
{
    public static class Data
    {
        public static List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> output = new List<CustomerModel>();

            output.Add(new CustomerModel { CustomerName = "Nikita", HourlyRateToBill = 160 });
            output.Add(new CustomerModel { CustomerName = "Ira", HourlyRateToBill = 125 });

            return output;
        } 

        public static EmployeeModel GetCurrentEmployee()
        {
            EmployeeModel output = new EmployeeModel 
            { 
                FirstName = "Vlad",
                LastName = "Lumberjack",
                HourlyRate = 15 
            };

            return output;
        }
    }
}
