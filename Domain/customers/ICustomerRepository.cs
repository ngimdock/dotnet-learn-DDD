using System;
using Domain.Customers;

public interface ICustomerRepository {
  Task<Customer?> findOneByIdAsync(CustomerId id);
}
