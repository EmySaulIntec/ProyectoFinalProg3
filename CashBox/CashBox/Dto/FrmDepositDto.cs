using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProject.Models;

namespace CashBox.Dto
{
    public class FrmDepositDto
    {
        public FrmDepositDto()
        {
            CoinElements = new List<int>();
        }

        public string Identification { get; set; }
        public string OriginAccount { get; set; }
        public string DestinyAccount { get; set; }
        public decimal Amount { get; set; }
        public IdentificationTypeEnum IdentificationType { get; set; }

        public List<int> CoinElements { get; set; }
    }
}
