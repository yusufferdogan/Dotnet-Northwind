using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract;
using Entities.Concrete;

public interface IProductDal : IEntityRepository<Product>
{
    List<ProductDetailDto> GetProductDetails();
}