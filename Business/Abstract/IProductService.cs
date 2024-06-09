using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract;
using Entities.Concrete;

public interface IProductService
{
    IDataResult<List<Product>> GetAll();

    IDataResult<List<Product>> GetAllByCategoryId(int id);

    IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

    IDataResult<List<ProductDetailDto>> GetProductDetails();

    IResult Add(Product product);

    IResult Update(Product product);

    IResult Delete(Product product);

    Product GetById(int productId);

    IDataResult<List<Product>> GetByProductNameAndCategory(string productName, int categoryId);

    IDataResult<List<Product>> GetByProductNameOrCategory(string productName, int categoryId);
}
