using System;
using Domain.Products;
using Domain.Customers;

namespace Domain.Orders;


public class Order {
  public Guid Id { get; private set; }

  public Guid CustomerId { get; private set; }

  private readonly HashSet<LineItem> _lineItems = new();

  private Order(Guid id, Guid customerId) {
    Id = id;
    CustomerId = customerId;
  }

  public static create(Customer customer ) {
    return new Order(Guid.NewGuid(), customer.Id);
  }

  public void add(Product product) {
    
    var lineItem = LineItem.Create(Guid.NewGuid(), Id, product.Id, product.Price);

    _lineItems.Add(lineItem);
  }
}

