using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Kvickly_Connect.Pages;

namespace Kvickly_Connect.Interfaces
{
    interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
        Customer GetCustomer(string id);
    }
}
