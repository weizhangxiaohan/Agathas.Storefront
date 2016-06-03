
using Agathas.Storefront.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Products
{
    public class ProductSize : EntityBase<int>, IProductAttribute
    {
        public int id { get; set; }

        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
