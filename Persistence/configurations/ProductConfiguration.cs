using Domain.Products;

internal class ProductConfiguration: IEntityTypeConfiguration<Product>{
    public void configure(EntityTypeBuilder<Customer> builder) {
    
    builder.HasKey(p => p.Id);

    builder.Property(p => p.Id).HasConversion(
      productId => productId.Value,
      value => new ProductId(value)
    );

    builder.Property(p => p.Name).HasMaxLength(200);

    builder.Property(p => p.Sku).HasConversion(
      sku => sku.Value,
      value => Sky.Create(value)!
    );

    builder.OwnsOne(p => p.Price, priceBuilder => {
      priceBuilder.Property(m => m.Currency).HasMaxLength(3);

      priceBuilder.Property(m => m.Amount);
    });
    
  }
}