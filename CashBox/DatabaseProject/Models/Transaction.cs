using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseProject.Models
{
    public class Transaction : BaseEntity
    {
        public TransactionTypeEnum TransactionType { get; set; }
        public decimal Amount { get; set; }

        public string OriginAccount { get; set; }

        public string DestinyAccount { get; set; }
        public long CasherId { get; set; }

        public string Identification { get; set; }
        public IdentificationTypeEnum IdentificationType { get; set; }

        [ForeignKey(nameof(CasherId))]
        public virtual User Casher { get; set; }
        public TransactionStatusEnum Status { get; set; }

        public override string ToString()
        {
            if (this.TransactionType == TransactionTypeEnum.Deposit)
                return $"({this.Id}) - Deposito: desde {this.OriginAccount} hasta {this.DestinyAccount} - {CreationTime.ToShortDateString()}";
            else
                return $"({this.Id}) - Retiro: de la cuenta {this.OriginAccount} - {CreationTime.ToShortDateString()}";
        }
    }

    public enum TransactionStatusEnum : int
    {
        Completed = 1,
        Incompleted = 2
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
