using Domain.Orders;


internal class OrderConfiguration: IEntityTypeConfiguration<Order> {
  public void configure(EntityTypeBuilder<Customer> builder) {
    
    builder.HasKey(o => o.Id);

    builder.Property(o => o.Id).HasConversion(
      orderId => orderId.Value,
      value => new OrderId(value)
    );

    builder.HasOne<Customer>()
      .WithMany()
      .HasForeignKey(o => o.CustomerId)
      .isRequired();
    
    builder.HasMany(o => o.LineItems)
      .WithOne()
      .HasForeignKey(o => o.OrderOd)
      .isRequired()
      .Ondelete(DeleteBehavoir.Cascade);
  }
}