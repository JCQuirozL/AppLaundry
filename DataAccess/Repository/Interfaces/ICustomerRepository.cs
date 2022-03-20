using AppLaundry.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        void Update(Customer customer);
        IEnumerable<SelectListItem> GetCustomerList();
    }
}
