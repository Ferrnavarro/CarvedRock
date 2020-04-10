using CarvedRock.Api.Data;
using CarvedRock.Api.Interfaces;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockQuery: ObjectGraphType
    {
        public CarvedRockQuery(IProductRepository productRepository)
        {
            Field<ListGraphType<Types.ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
                );
        }
    }
}
