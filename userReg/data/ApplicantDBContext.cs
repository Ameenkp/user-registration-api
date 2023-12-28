using userReg.Models;

namespace userReg.data;

using Microsoft.EntityFrameworkCore;

public class ApplicantDbContext(DbContextOptions<ApplicantDbContext> options) : DbContext(options)
{
    public required DbSet<Applicant> Applicants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Applicant>()
            .Property(u => u.AppNoYears)
            .HasColumnType("decimal(18,2)");
    }
}
