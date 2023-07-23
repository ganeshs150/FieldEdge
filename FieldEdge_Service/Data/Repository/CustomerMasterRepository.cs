using Data.Entities;
using Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CustomerMasterRepository : ICustomerMasterRepository
    {
        private readonly FieldEdgeDBContext _appDBContext;
        public CustomerMasterRepository(FieldEdgeDBContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<CustomerMaster>> GetCustomers()
        {
            return await _appDBContext.CustomerMaster.ToListAsync();
        }
    }
}
