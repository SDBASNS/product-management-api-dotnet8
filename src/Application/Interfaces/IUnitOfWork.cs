using Domain.Entities;

namespace Application.Interfaces;

public interface IUnitOfWork
{
    IRepository<Product> Products { get; }

    Task<int> SaveChangesAsync();
}