using System.Linq;

namespace OutbackProducts.Models
{ 
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}