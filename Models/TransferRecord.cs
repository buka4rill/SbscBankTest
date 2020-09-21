namespace SbscBankTest.Models
{
    public class TransferRecord
    {
        public string AccountNumber { get; set; }

        public string Type { get; set; } // Credit or Debit

        public string amount { get; set; }

        public string Department { get; set; } // Record Management Department
    }
}