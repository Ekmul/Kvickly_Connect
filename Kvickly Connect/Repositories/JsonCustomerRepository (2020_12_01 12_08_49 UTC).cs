using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Kvickly_Connect.Helpers;
using Kvickly_Connect.Interfaces;

namespace Kvickly_Connect.Repositories
{
    public class JsonCustomerRepository : ICustomerRepository
    {
        string JsonFileName = @"C:\Users\Emil Glæsner\source\repos\Kvickly Connect\Kvickly Connect\Data\jsonUsers.json";

        public List<Customer> GetAllCustomers()
        {
            return JsonFileReader.ReadCustomerJson(JsonFileName);
        }
        public void AddCustomer(Customer customer)
        {
            List<Customer> customers = GetAllCustomers();
            customers.Add(customer);
            JsonFileWritter.WriteCustomerToJson(customers, JsonFileName);
        }

        public Customer GetCustomer(string customerId)
        {
            return null;
        }

    }
}
