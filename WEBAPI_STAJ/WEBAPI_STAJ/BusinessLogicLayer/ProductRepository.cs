using WEBAPI_STAJ.DataAccessLayer;
using WEBAPI_STAJ.Models;

namespace WEBAPI_STAJ.BusinessLogicLayer
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public void Insert(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Product entity)
        {
            _context.Products.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }

        public Product FindById(params object[] values)
        {
            return _context.Products.Find(values);
        }

        public IEnumerable<Product> FindAll()
        {
            return _context.Products.ToList();
        }

        public Product FindByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public IEnumerable<Product> FindByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _context.Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }
    }
}
