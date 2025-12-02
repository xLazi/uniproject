using CarServiceMy.BL.Interfaces;
using CarServiceMy.DL.Interfaces;
using CarServiceMy.Models.Entities;

namespace CarServiceMy.BL.Services
{
    internal class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(
            ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer? customer)
        {
            if (customer == null) return;

            _customerRepository.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer? GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}
