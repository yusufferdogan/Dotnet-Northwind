using Core.Entities;

namespace Entities.Concrete;

public class Category: IEntity
{
    public int CategoryId { get; set; }
    
    public string CategoryName { get; set; }
    
    public override string ToString()
    {
        return $"CategoryId: {CategoryId,-10} CategoryName: {CategoryName,-20}";
    }
}