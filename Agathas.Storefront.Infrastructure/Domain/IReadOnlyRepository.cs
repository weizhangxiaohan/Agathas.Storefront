﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agathas.Storefront.Infrastructure;
using Agathas.Storefront.Infrastructure.Querying;

namespace Agathas.Storefront.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T,TId> where T : IAggregateRoot
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Query q);
        IEnumerable<T> FindBy(Query q,int index,int count);
    }
}
