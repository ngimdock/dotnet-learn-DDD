
using Domain.Orders;
using Domain.Products;

internal class LineItemConfiguration: IEntityTypeConfiguration<LineItem> {
  public void configure(EntityTypeBuilder<Customer> builder) {
    
    builder.HasKey(li => li.Id);

    builder.Property(li => li.Id).HasConversion(
      lineItelId => lineItelId.Value,
      value => new LineItemId(value)
    );

    builder.HasOne<Product>()
      .WithMany()
      .HasForeignKey(li => li.ProductId);

    builder.OwnsOne(li => li.Price);
  }
}
