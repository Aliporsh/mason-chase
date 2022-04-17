using Afshar_test.DTOs;
using Afshar_test.Models.entity;
using System.Collections.Generic;

namespace Afshar_test.Services.InterFaces
{
    public interface ICustomerService
    {

        List<Customer> GetAllCustomers();

        int CreateCustomer(CustomerForSHowViewModel cm);

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(int ID);

        bool IsAnyEmail(string email);
        bool IsAnyPHone(string phone);
        Customer GetCustomer(int id);
    }
}
