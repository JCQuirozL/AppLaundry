using AppLaundry.Data;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class WorkUnity:IWorkUnity
    {
        public ApplicationDbContext context { get; set; }
        public ICustomerRepository CustomerRepo { get; set; }

        public WorkUnity(ApplicationDbContext _context)
        {
            context = _context;
            CustomerRepo = new CustomerRepository(context);
            
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
