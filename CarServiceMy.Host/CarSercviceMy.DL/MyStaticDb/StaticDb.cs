using CarServiceMy.Models.Entities;

namespace CarServiceMy.DL.MyStaticDb
{
    internal static class StaticDb
    {
        internal static List<Customer> Customers { get; set; } = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "John Doe",
                Email = "jd@xxx.com"
            },
            new Customer()
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "js@xxx.com"
            }
        };
    }
}