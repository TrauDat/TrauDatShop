using System;

namespace TrauDatShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TrauDatShopDbContext Init();
    }
}