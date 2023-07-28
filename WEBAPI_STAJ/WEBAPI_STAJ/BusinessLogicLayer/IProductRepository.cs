using WEBAPI_STAJ.Models;

namespace WEBAPI_STAJ.BusinessLogicLayer
{
    public interface IProductRepository : IRepository<Product>
    {
        Product FindByName(string name);
        IEnumerable<Product> FindByPriceRange(decimal minPrice, decimal maxPrice);

    }
}
