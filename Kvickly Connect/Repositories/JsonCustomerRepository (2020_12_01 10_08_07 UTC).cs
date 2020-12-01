using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Kvickly_Connect.Helpers;

namespace Kvickly_Connect.Services
{
    public class JsonCustomerRepository
    {
        string JsonFileName = @"AFilePath";

        public Dictionary<int, Customer> GetAllCustomers()
        {
            return JsonFileReader.ReadCustomerJson(JsonFileName);
        }
        public void AddCustomer(Customer customer)
        {
            Dictionary<int, Customer> customers = GetAllCustomers();
            //customers.Add(customer);
            //JsonFileWritter.WriteToJson(customers, JsonFileName);
        }

    }
}
