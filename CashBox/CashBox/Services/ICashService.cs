using DatabaseProject.Models;

namespace CashBox.Services
{
    public interface ICashService
    {
        void Deposit(Transaction transaction);

        void Retirement(Transaction transaction);
    }
}