using CarvedRock.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
