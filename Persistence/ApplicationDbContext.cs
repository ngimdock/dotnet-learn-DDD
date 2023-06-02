using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class ApplicationDbContext: DbContext {
  protected override void Onconfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseNpgSql();
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
  }
}