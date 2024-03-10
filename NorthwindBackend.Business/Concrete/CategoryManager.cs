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
public class CategoryManager : ICategoryService
{
	private ICategoryDal _categoryDal;

	public CategoryManager(ICategoryDal categoryDal)
	{
		_categoryDal = categoryDal;
	}

	public IDataResult<Category> GetById(int categoryId)
	{
		try
		{
			return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId),
				Messages.SuccessCategorySelected);
		}
		catch (Exception e)
		{
			return new ErrorDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId),
				$"{Messages.ErrorCategorySelected}\n{e.Message}");
		}
	}

	public IDataResult<List<Category>> GetList()
	{
		try
		{
			return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList(),
				Messages.SuccessCategoryListed);
		}
		catch (Exception e)
		{
			return new ErrorDataResult<List<Category>>(_categoryDal.GetList().ToList(),
				$"{Messages.ErrorCategoryListed}\n{e.Message}");
		}
	}
	
	public IResult Add(Category category)
	{
		try
		{
			_categoryDal.Add(category);
			return new SuccessResult(Messages.SuccessCategoryAdded);
		}
		catch (Exception e)
		{
			return new ErrorResult($"{Messages.ErrorCategoryAdded}\n{e.Message}");
		}
	}

	public IResult Update(Category category)
	{
		try
		{
			_categoryDal.Update(category);
			return new SuccessResult(Messages.SuccessCategoryUpdated);
		}
		catch (Exception e)
		{
			return new ErrorResult($"{Messages.ErrorCategoryUpdated}\n{e.Message}");
		}
	}

	public IResult Delete(Category category)
	{
		try
		{
			_categoryDal.Delete(category);
			return new SuccessResult(Messages.SuccessCategoryDeleted);
		}
		catch (Exception e)
		{
			return new ErrorResult($"{Messages.ErrorCategoryDeleted}\n{e.Message}");
		}
	}
}
