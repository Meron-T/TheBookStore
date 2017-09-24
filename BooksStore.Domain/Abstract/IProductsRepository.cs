using System.Collections.Generic;
using BooksStore.Domain.Entities;

namespace BooksStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
