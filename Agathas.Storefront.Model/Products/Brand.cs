using Agathas.Storefront.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Products
{
    public class Brand : EntityBase<int>, IProductAttribute
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public int id { get; set; }

        public string Name { get; set; }
    }
}
