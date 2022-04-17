using Afshar_test.DTOs;
using Afshar_test.Models.entity;
using Afshar_test.Services.InterFaces;
using Alavan.Datalayer.Context;
using System.Collections.Generic;
using System.Linq;

namespace Afshar_test.Services
{
    public class CustomerService : ICustomerService
    {
        private AfsharContext db;
        public CustomerService(AfsharContext _db)
        {
            db=_db;
        }

        public int CreateCustomer(CustomerForSHowViewModel cm)
        {
            Customer customer = new Customer()
            {
               BankAccountNumber= cm.BankAccountNumber,
               DateOfBirth= cm.DateOfBirth,
               Email= cm.Email,
               Firstname=cm.Firstname,
               Lastname=cm.Lastname,
               PhoneNumber= cm.PhoneNumber
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer.ID;
        }

        public void DeleteCustomer(int ID)
        {
            Customer customer= GetCustomer(ID);
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList(); 
        }

        public Customer GetCustomer(int id)
        {
          return db.Customers.Find(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            db.Customers.Update(customer);
            db.SaveChanges();
        }
    }
}
