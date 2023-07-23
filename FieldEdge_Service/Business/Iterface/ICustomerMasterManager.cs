using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Iterface
{
    public interface ICustomerMasterManager
    {
        Task<IEnumerable<CustomerMaster>> GetCustomers();
    }
}
