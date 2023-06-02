using Domain.Customers;


internal class CustomerConfiguration: IEntityTypeConfiguration<Custumer> {
  
  public void configure(EntityTypeBuilder<Customer> builder) {
    
    builder.HasKey(c => c.Id);

    builder.Property(c => c.Id).HasConversion(
      customerId => customerId.Value,
      value => new CustomerId(value)
    );

    builder.Property(c => c.Name).HasMaxLength(100);
    
    builder.Property(c => c.Email).HasMaxLength(255);

    builder.HasIndex(c => c.Email).IsUnique();
  }
} 