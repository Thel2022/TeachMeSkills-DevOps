using System.Collections.Generic;

namespace WebApplication1DevOps.Models
{
    public interface IMarket
    {
        IEnumerable<Product> GetAll();
        Product Get(string id);
        Product Add(Product item);
        void Remove(string id);
        bool Update(Product item);
    }
}
