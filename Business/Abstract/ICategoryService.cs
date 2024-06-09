using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICategoryService
{
    IDataResult<List<Category>> GetAll();
    IDataResult<Category> GetById(int categoryId);
    
    IDataResult<Category> GetByName(string categoryName);
    
    IResult Add(Category category);
    
    IResult Update(Category category);

    IResult Delete(Category category);


}