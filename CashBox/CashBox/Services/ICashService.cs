using DatabaseProject.Models;
using System.Collections.Generic;

namespace CashBox.Services
{
    public interface ICashService
    {
        void Deposit(Transaction transaction, Dto.FrmDepositDto frmDepositDto);

        void Retirement(Transaction transaction, List<MCoin> coinsAdded);
    }
}