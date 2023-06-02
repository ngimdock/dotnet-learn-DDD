
namespace Domain.Products;


// In DDD this is call a Value object, a value object is immutable and 2 values objects are same if all properties is equals
public record Money(string Currency, decimal Amount); 