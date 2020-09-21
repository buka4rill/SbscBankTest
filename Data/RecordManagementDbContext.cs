using Microsoft.EntityFrameworkCore;
using SbscBankTest.Models;

namespace SbscBankTest.Data
{
    public class RecordManagementDbContext : DbContext
    {
        // Constructor
        public RecordManagementDbContext(DbContextOptions<RecruitmentDbContext> options)
        {

        }

        // Tables
        public DbSet<StaffRecord> StaffRecords { get; set; }

        public DbSet<SalaryRecord> SalaryRecords { get; set; }

        public DbSet<TransferRecord> TransferRecords { get; set; }
    }
}