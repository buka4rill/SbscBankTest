using Microsoft.EntityFrameworkCore;
using SbscBankTest.Models;

namespace SbscBankTest.Data
{
    public class RecordManagementDbContex : DbContext
    {
        // Constructor
        public RecordManagementDbContex(DbContextOptions<RecruitmentDbContext> options)
        {

        }

        // Tables
        public DbSet<StaffRecord> StaffRecords { get; set; }

        public DbSet<SalaryRecord> SalaryRecords { get; set; }

        public DbSet<TransferRecord> TransferRecords { get; set; }
    }
}