using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseProject.Models
{
    public class DailyClose : BaseEntity
    {
        public double InitialAmount { get; set; }
        public double FinalAmount { get; set; }
        public long CasherId { get; set; }

        [ForeignKey(nameof(CasherId))]
        public virtual User Casher { get; set; }
    }
}