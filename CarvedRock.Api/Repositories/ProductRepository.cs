using CarvedRock.Api.Data;
using CarvedRock.Api.Data.Entities;
using CarvedRock.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public ProductRepository(CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products;
        }
    }
}
