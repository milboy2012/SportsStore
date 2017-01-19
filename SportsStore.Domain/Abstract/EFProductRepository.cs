using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Concrete;

namespace SportsStore.Domain.Abstract
{
    //класс хранилища
    public class EFProductRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Product> Products {
            get { return context.Products; }
        }
    }
}
