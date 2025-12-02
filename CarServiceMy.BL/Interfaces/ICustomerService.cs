using CarServiceMy.Models.Entities;

namespace CarServiceMy.BL.Interfaces
{
    public interface ICustomerService
    {
        void Add(Customer? customer);
        List<Customer> GetAll();
        Customer? GetById(int id);
        void Delete(int id);
    }
}
