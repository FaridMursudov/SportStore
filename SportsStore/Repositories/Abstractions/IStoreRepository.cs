using SportsStore.Models;
using System.Linq;

namespace SportsStore.Repositories.Abstractions
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
