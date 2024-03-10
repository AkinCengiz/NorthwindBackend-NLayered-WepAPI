using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBackend.Core.Utilities.Results;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.Business.Abstract;
public interface IProductService
{
    IDataResult<Product> GetById(int productId);
    IDataResult<List<Product>> GetList();
    IDataResult<List<Product>> GetListByCategoryId(int categoryId);
    IDataResult<List<Product>> GetListByCategory(Category category);
	IResult Add(Product product);
    IResult Update(Product product);
    IResult Delete(Product product);
}
