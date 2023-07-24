using Model.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Iterface
{
    public interface ICustomerMasterManager
    {
        Task<IEnumerable<CustomerViewModel>> GetCustomers();
        Task<CustomerViewModel> GetCustomerById(int id);
        Task<string> Upsert(CustomerRequest customerRequest);
        string DeleteCustomer(int id);
    }
}
