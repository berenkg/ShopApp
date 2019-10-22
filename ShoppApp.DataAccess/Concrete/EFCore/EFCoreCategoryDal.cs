using ShopApp.Entities;
using ShoppApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShoppApp.DataAccess.Concrete.EFCore
{
    public class EFCoreCategoryDal : EFCore_GenericRepository<Category, ShopContext>, ICategoryDal
    {

        
    }
}
