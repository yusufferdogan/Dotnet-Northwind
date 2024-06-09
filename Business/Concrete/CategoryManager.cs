using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
// ReSharper disable CheckNamespace

namespace Business.Concrete;

public class CategoryManager:ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    
    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public IDataResult<Category> GetById(int categoryId)
    {
        return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
    }

    public IDataResult<Category> GetByName(string categoryName)
    {
        return new SuccessDataResult<Category>(_categoryDal.Get( p => p.CategoryName == categoryName));
    }

    public IResult Add(Category category)
    {
        _categoryDal.Add(category);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Update(Category category)
    {
        _categoryDal.Update(category);
        return new SuccessResult(Messages.CategoryUpdated);
    }

    public IResult Delete(Category category)
    {
        _categoryDal.Delete(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }

    IDataResult<List<Category>> ICategoryService.GetAll()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
    }
}