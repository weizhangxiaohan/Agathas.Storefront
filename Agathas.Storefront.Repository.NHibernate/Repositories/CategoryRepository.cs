﻿using Agathas.Storefront.Infrastructure.UnitOfWork;
using Agathas.Storefront.Model.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Repository.NHibernate.Repositories
{
    public class CategoryRepository : Repository<Category, int>,ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork uow)
             : base(uow)
        {
        }
    }
}
