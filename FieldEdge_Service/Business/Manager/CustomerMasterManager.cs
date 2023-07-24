using AutoMapper;
using Business.Iterface;
using Data.Entities;
using Data.Interface;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class CustomerMasterManager : ICustomerMasterManager
    {
        private readonly IMapper _mapper;
        private readonly ICustomerMasterRepository _customerMasterRepository;
        public CustomerMasterManager(ICustomerMasterRepository customerMasterRepository, IMapper mapper)
        {
            _customerMasterRepository = customerMasterRepository ??
                throw new ArgumentNullException(nameof(customerMasterRepository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerViewModel>> GetCustomers()
        {
            var result = await _customerMasterRepository.GetCustomers();
            return _mapper.Map<IEnumerable<CustomerMaster>, IEnumerable<CustomerViewModel>>(result);
        }

        public async Task<CustomerViewModel> GetCustomerById(int id)
        {
            var result = await _customerMasterRepository.GetCustomerById(id);
            return _mapper.Map<CustomerMaster, CustomerViewModel>(result);
        }

        public async Task<string> Upsert(CustomerRequest customerRequest)
        {
            CustomerMaster customerMaster = new CustomerMaster()
            {
                id = customerRequest.id,
                firstname = customerRequest.firstname,
                lastname = customerRequest.lastname,
                email = customerRequest.email,
                phone_number = customerRequest.phone_number,
                country_code = customerRequest.country_code,
                gender = customerRequest.gender
            };
            await _customerMasterRepository.Upsert(customerMaster);

            if (customerRequest.id == 0)
                return "Customer detail saved successfully";
            else
                return "Customer detail updated successfully";
        }

        public string DeleteCustomer(int id)
        {
            var result = _customerMasterRepository.DeleteCustomer(id);
            if (result)
                return "Customer record deleted successfully";
            else
                return "Customer record not deleted";
        }
    }
}
