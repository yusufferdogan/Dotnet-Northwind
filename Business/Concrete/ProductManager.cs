using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Bussiness.Concrete;

public class ProductManager: IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    
    public IDataResult<List<Product>> GetAll()
    {
        if (DateTime.Now.Hour == 22) return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
        return new SuccessDataResult<List<Product>>(_productDal.GetAll());
    }

    public IDataResult<List<Product>> GetAllByCategoryId(int id)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
    }

    public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
    {
        // Get all products within the specified price range
        var products = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);

        return new SuccessDataResult<List<Product>>(products.OrderBy(p => p.UnitPrice).ToList());
    }
    
    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
    }

    public IResult Add(Product product)
    {
        if(product.ProductName.Length < 2)
        {
            return new ErrorResult(Messages.ProductNameInvalid);
        }
        _productDal.Add(product);
        return new SuccessResult( Messages.ProductAdded);
    }

    public IResult Update(Product product)
    {
        _productDal.Update(product);
        return new SuccessResult( Messages.ProductUpdated);
    }

    public IResult Delete(Product product)
    {
        _productDal.Delete(product);
        return new SuccessResult( Messages.ProductDeleted);
    }

    public Product GetById(int productId)
    {
        return _productDal.Get(p => p.ProductId == productId);
    }

    public IDataResult<List<Product>> GetByProductNameAndCategory(string productName, int categoryId)
    {
        
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.ProductName.Contains(productName) && p.CategoryId == categoryId));
    }

    public IDataResult<List<Product>> GetByProductNameOrCategory(string productName, int categoryId)
    {
        return new SuccessDataResult<List<Product>>(
            _productDal.GetAll(p => p.ProductName.Equals(productName) || p.CategoryId == categoryId));
    }
}
