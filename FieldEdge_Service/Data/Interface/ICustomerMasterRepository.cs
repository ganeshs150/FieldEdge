using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface ICustomerMasterRepository
    {
        Task<IEnumerable<CustomerMaster>> GetCustomers();
    }
}
