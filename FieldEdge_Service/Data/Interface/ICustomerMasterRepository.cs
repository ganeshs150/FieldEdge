using Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface ICustomerMasterRepository
    {
        Task<IEnumerable<CustomerMaster>> GetCustomers();
        Task<CustomerMaster> GetCustomerById(int id);
        Task<CustomerMaster> Upsert(CustomerMaster customerMaster);
        bool DeleteCustomer(int id);
    }
}
