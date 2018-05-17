using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrauDatShop.Data.Infrastructure;
using TrauDatShop.Model.Models;

namespace TrauDatShop.Data.Repositories
{

    public interface IContactDetailRepository : IRepository<ContactDetail>
    {
    }
    public class ContactDetailRepository : RepositoryBase<ContactDetail>, IContactDetailRepository
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
