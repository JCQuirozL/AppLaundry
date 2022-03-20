using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface IWorkUnity
    {
        public ICustomerRepository CustomerRepo { get; set; }
        void Save();
    }
}
