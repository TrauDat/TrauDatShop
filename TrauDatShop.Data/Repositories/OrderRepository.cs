using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using TrauDatShop.Common.ViewModels;
using TrauDatShop.Data.Infrastructure;
using TrauDatShop.Model.Models;

namespace TrauDatShop.Data.Repositories
{
    public interface IOrderRepository  : IRepository<Order>
    {
        IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate);
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate)
        {
            var parameters = new SqlParameter[]{
                new SqlParameter("@fromDate",fromDate),
                new SqlParameter("@toDate",toDate)
            };
            return DbContext.Database.SqlQuery<RevenueStatisticViewModel>("GetRevenueStatistic @fromDate, @toDate", parameters);
        }
    }
}