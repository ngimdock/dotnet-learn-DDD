using System;
using Domain.Products;


namespace Domain.Orders;

public class LineItem {
  
  public Guid Id { get; private set; }

  public Guid OrderId { get; private set; }

  public Guid ProductId { get; private set; }

  public Money Price { get; private set; }

  private LineItem (Guid id, Guid orderId, Guid productId, Money price) {
    Id = id;
    OrderId = orderId;
    ProductId = productId;
    Price = price;
  }

  public static LineItem? Create(Guid id, Guid orderId, Guid productId, Money price) {
    return new LineItem(id, orderId, productId, price);
  }
}