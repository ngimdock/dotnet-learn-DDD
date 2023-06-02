

namespace Domain.Products;

// In many cases, values objects can have some validation before creation. Here we using a factory method
public record Sku { // Stock Kipping Unit

  public string Value { get; } // Here we don't have set because in DDD, value object are imutable

  private const int DefaultLength = 15;

  private Sku(string value) => Value = value;


  public static Sku? Create(string value) {

    if(string.IsNullOrEmpty(value)) {
      return null;
    }

    if(value.Length != DefaultLength) {
      return null;
    }

    return new Sku(value);
  }
}