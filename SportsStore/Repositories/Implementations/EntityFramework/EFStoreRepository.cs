using SportsStore.DbContexts;
using SportsStore.Models;
using SportsStore.Repositories.Abstractions;
using System.Linq;

namespace SportsStore.Repositories.Implementations.EntityFramework
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext _dbContext;

        public EFStoreRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Product> Products => _dbContext.Products;
    }
}
