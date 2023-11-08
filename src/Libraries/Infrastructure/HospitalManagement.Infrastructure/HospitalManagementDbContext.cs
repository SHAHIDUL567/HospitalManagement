using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Infrastructure;

public class HospitalManagementDbContext: DbContext
{
    public HospitalManagementDbContext(DbContextOptions <HospitalManagementDbContext>options):base(options) {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospitalManagementDbContext).Assembly);
    }
}
