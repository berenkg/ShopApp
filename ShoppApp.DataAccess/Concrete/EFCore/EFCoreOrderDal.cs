using ShopApp.Entities;
using ShoppApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp.DataAccess.Concrete.EFCore
{
    public class EFCoreOrderDal: EFCore_GenericRepository<Order, ShopContext>, IOrderDal
    {
    }
}
