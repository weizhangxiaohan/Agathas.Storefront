using Agathas.Storefront.Infrastructure.Domain;
using Agathas.Storefront.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Categories
{
    public class Category : EntityBase<int>, IAggregateRoot, IProductAttribute
    {

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public int id { get; set; }

        public string Name { get; set; }
    }
}
