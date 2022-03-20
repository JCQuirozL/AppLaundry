using AppLaundry.Data;
using AppLaundry.Models;
using DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public ApplicationDbContext Context { get; set; }
        public CustomerRepository(ApplicationDbContext _context) : base(_context)
        {
            Context = _context;
        }

        public IEnumerable<SelectListItem> GetCustomerList()
        {
            return Context.Customers.Select(c => new SelectListItem()
            {
                Text = c.LastName + " " + " " + c.FirstName,
                Value = c.Id.ToString()
            });
        }

        public void Update(Customer customer)
        {
            Customer customerDb = Context.Customers.FirstOrDefault(c => c.Id == customer.Id);
            customerDb.LastName = customer.LastName;
            customerDb.FirstName = customer.FirstName;
            customerDb.Phone= customer.Phone;
            customerDb.Email = customer.Email;
                       
        }
    }
}
