using System;

namespace  Domain.Customers;


public class Customer {

  public Guid Id { get; private set; } // Customer is and entity and in DDD all entities have to be unique, that is the role of this id
  public string Email { get; private set; } = string.Empty;

  public string Name { get; private set; } = string.Empty;
}