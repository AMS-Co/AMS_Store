using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain.CustomerAggregate.Models;
using static System.Formats.Asn1.AsnWriter;

namespace Domain.CustomerAggregate.Interfaces.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetById(long id);
        Task<IEnumerable<Customer>> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);
        void RemoveById(long id);
        Task<Customer> GetByNationalCode(string nationalCode);
    }
}
