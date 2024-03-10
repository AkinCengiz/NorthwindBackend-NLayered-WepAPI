using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBackend.Business.Abstract;
using NorthwindBackend.Business.Constants;
using NorthwindBackend.Core.Utilities.Results;
using NorthwindBackend.DataAccess.Abstract;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.Business.Concrete;
public class ProductManager : IProductService
{
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        this._productDal = productDal;
    }

    public IDataResult<Product> GetById(int productId)
    {
	    try
	    {
		    return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId),Messages.SuccessProductSelected);
		}
	    catch (Exception e)
	    {
		    return new ErrorDataResult<Product>(_productDal.Get(p => p.ProductId == productId), $"{Messages.ErrorProductSelected}\n{e.Message}");
	    }
        
    }

    public IDataResult<List<Product>> GetList()
    {
	    try
	    {
		    return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList(),Messages.SuccessProductListed);
	    }
	    catch (Exception e)
	    {
		    return new ErrorDataResult<List<Product>>(_productDal.GetList().ToList(), $"{Messages.ErrorProductListed}\n{e.Message}");
	    }
    }

    public IDataResult<List<Product>> GetListByCategoryId(int categoryId)
    {
	    try
	    {
		    return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId).ToList(),Messages.SuccessProductListed);
	    }
	    catch (Exception e)
	    {
		    return new ErrorDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId).ToList(),
			    $"{Messages.ErrorProductListed}\n{e.Message}");
	    }
    }

    public IDataResult<List<Product>> GetListByCategory(Category category)
    {
		try
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == category.CategoryId).ToList(), Messages.SuccessProductListed);
		}
		catch (Exception e)
		{
			return new ErrorDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == category.CategoryId).ToList(),
				$"{Messages.ErrorProductListed}\n{e.Message}");
		}
	}

    public IResult Add(Product product)
    {
	    try
	    {
		    _productDal.Add(product);
		    return new SuccessResult(Messages.SuccessProductAdded);
	    }
	    catch (Exception e)
	    {
		    return new ErrorResult($"{Messages.ErrorProductAdded}\n{e.Message}");
	    }
    }

    public IResult Update(Product product)
    {
	    try
	    {
			_productDal.Update(product);
			return new SuccessResult(Messages.SuccessProductUpdated);
	    }
	    catch (Exception e)
	    {
		    return new ErrorResult($"{Messages.ErrorProductUpdated}\n{e.Message}");
	    }
    }

    public IResult Delete(Product product)
    {
	    try
	    {
		    _productDal.Delete(product);
		    return new SuccessResult(Messages.SuccessProductDeleted);
	    }
	    catch (Exception e)
	    {
		    return new ErrorResult($"{Messages.ErrorProductDeleted}\n{e.Message}");
	    }
    }
}
