using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agathas.Storefront.Infrastructure;

namespace Agathas.Storefront.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T,TId> where T : IAggregateRoot
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Queryable q);
        IEnumerable<T> FindBy(Queryable q,int index,int count);
    }
}
