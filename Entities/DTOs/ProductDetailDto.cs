using Core.Entities;

namespace Entities.DTOs;

//tek basina bir tablo degil birden fazla tablonun join edilmesi sonucu olusan tablolar olabilir
public class ProductDetailDto:IDto
{
    public int ProductID { get; set; }
    
    public string ProductName { get; set; }
    
    public string CategoryName { get; set; }
    
    public short UnitsInStock { get; set; }

    public override string ToString()
    {
        return $"ProductID: {ProductID,-10} ProductName: {ProductName,-40} CategoryName: {CategoryName,-20} UnitsInStock: {UnitsInStock,-10}";
    }
}

