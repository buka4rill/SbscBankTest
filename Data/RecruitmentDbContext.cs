using Microsoft.EntityFrameworkCore;
using SbscBankTest.Models;

namespace SbscBankTest.Data
{
    public class RecruitmentDbContext : DbContext
    {
        // Constructor
        public RecruitmentDbContext(DbContextOptions<RecruitmentDbContext> options)
        {

        }

        // Tables
        public DbSet<WorkforcePlanningOfficer> WorkforcePlanningOfficers { get; set; }

        public DbSet<RecruitmentOfficer> RecruitmentOfficers { get; set; }

        // public DbSet
    }
}