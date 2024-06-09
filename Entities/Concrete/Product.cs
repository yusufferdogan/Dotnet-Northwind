using Core.Entities;

namespace Entities.Concrete;

public class Product: IEntity
{
    public int ProductId { get; set; }
    
    public int CategoryId { get; set; }
    
    public string ProductName { get; set; }
    
    public decimal UnitPrice { get; set; }
    
    public short UnitsInStock { get; set; }


    public override string ToString()
    {
        return $"ProductId: {ProductId,-10} ProductName: {ProductName,-30} UnitPrice: {UnitPrice,-10:C} UnitsInStock: {UnitsInStock,-10} CategoryId: {CategoryId,-10}";
    }
}