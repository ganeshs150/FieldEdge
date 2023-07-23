using Business.Iterface;
using Data.Entities;
using Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class CustomerMasterManager : ICustomerMasterManager
    {
        private readonly ICustomerMasterRepository _customerMasterRepository;
        public CustomerMasterManager(ICustomerMasterRepository customerMasterRepository)
        {
            _customerMasterRepository = customerMasterRepository ??
                throw new ArgumentNullException(nameof(customerMasterRepository));
        }

        public async Task<IEnumerable<CustomerMaster>> GetCustomers()
        {
            return await _customerMasterRepository.GetCustomers();
        }
    }
}
