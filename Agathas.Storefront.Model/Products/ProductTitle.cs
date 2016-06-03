using Agathas.Storefront.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Products
{
    public class ProductTitle : EntityBase<int> , IAggregateRoot
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
