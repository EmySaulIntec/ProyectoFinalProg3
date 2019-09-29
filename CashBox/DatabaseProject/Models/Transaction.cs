using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseProject.Models
{
    public class Transaction : BaseEntity
    {
        public TransactionTypeEnum TransactionType { get; set; }
        public double Amount { get; set; }

        public string OriginAccount { get; set; }

        public string DestinyAccount { get; set; }
        public long CasherId { get; set; }
     
        public string Identification { get; set; }
        public IdentificationTypeEnum? IdentificationType { get; set; }

        [ForeignKey(nameof(CasherId))]
        public virtual User Casher { get; set; }
    }

    public enum TransactionTypeEnum : int
    {
        Deposit = 1,
        Retirement = 2
    }

    public enum IdentificationTypeEnum : int
    {
        Cedula = 1,
        Passport = 2
    }
}
