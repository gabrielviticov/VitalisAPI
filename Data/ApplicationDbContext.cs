using Microsoft.EntityFrameworkCore;
using VitalisAPI.Entities.Models;

namespace VitalisAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorModel>().OwnsOne(person => person.Person).WithOwner();
        modelBuilder.Entity<DoctorModel>().OwnsOne(address => address.Address).WithOwner();
    }

    public DbSet<DoctorModel> DoctorEntity { get; set; }
}