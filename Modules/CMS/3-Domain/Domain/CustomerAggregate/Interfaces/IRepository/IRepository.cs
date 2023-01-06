using Domain.Common;

namespace Domain.CustomerAggregate.Interfaces.IRepository
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
