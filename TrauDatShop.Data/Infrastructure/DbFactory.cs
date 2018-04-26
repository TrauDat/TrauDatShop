using TrauDatShop.Data;
using TrauDatShop.Data.Infrastructure;

namespace TrauDatShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TrauDatShopDbContext dbContext;

        public TrauDatShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TrauDatShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}