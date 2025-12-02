using CarServiceMy.Models.Entities;

namespace CarServiceMy.DL.Interfaces
{
    public interface ICarRepository
    {
        void Add(Car? customer);
        List<Car> GetAll();
        Car? GetById(int id);
        void Delete(int id);
    }
}
