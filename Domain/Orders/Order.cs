using System;
using Domain.Products;
using Domain.Customers;

namespace Domain.Orders;


public class Order {
  public OrderId Id { get; private set; }

  public CustomerId CustomerId { get; private set; }

  private readonly HashSet<LineItem> LineItems = new();

  private Order(OrderId id, CustomerId customerId) {
    Id = id;
    CustomerId = customerId;
  }

  public static Order create(CustomerId customerId) {

    var OrderId = new OrderId(Guid.NewGuid());

    return new Order(OrderId, customerId);
  }

  public void add(Product product) {
    
    var lineItem = LineItem.Create(Id, product.Id, product.Price);

    LineItems.Add(lineItem);
  }
}