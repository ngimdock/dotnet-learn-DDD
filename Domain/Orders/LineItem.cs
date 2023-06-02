using System;
using Domain.Products;
using Domain.Orders;


namespace Domain.Orders;

public class LineItem {
  
  public LineItemId Id { get; private set; }

  public OrderId OrderId { get; private set; }

  public ProductId ProductId { get; private set; }

  public Money Price { get; private set; }

  private LineItem (LineItemId id, OrderId orderId, ProductId productId, Money price) {
    Id = id;
    OrderId = orderId;
    ProductId = productId;
    Price = price;
  }

  public static LineItem Create(OrderId orderId, ProductId productId, Money price) {

    var lineItemId = new LineItemId(Guid.NewGuid());
    return new LineItem(lineItemId, orderId, productId, price);
  }
}