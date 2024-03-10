using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBackend.Core.DataAccess.EntityFramework;
using NorthwindBackend.DataAccess.Abstract;
using NorthwindBackend.DataAccess.Concrete.EntityFramework.Contexts;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.DataAccess.Concrete.EntityFramework;
public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
{
}
