using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        //temel veri erişim operasyonları Select-del-uptade-insert

    }
}
