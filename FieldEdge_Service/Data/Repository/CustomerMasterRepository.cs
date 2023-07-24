using Data.Entities;
using Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<CustomerMaster> GetCustomerById(int id)
        {
            return await _appDBContext.CustomerMaster.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<CustomerMaster> Upsert(CustomerMaster customerMaster)
        {
            if (customerMaster.id == 0)
            {
                _appDBContext.CustomerMaster.Add(customerMaster);
                await _appDBContext.SaveChangesAsync();
            }
            else
            {
                _appDBContext.Entry(customerMaster).State = EntityState.Modified;
                await _appDBContext.SaveChangesAsync();
            }
            return customerMaster;
        }

        public bool DeleteCustomer(int id)
        {
            bool result = false;
            var customer = _appDBContext.CustomerMaster.Find(id);
            if (customer != null)
            {
                _appDBContext.Entry(customer).State = EntityState.Deleted;
                _appDBContext.SaveChanges();
                result = true;
            }
            else
                result = false;

            return result;
        }

    }
}
