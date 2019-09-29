using DatabaseProject.Models;

namespace CashBox.Services
{
    public class IntegrationLayer : IIntegrationLayer
    {
        public bool Deposit(string originAccount, string destinyAccount, string identification, IdentificationTypeEnum identificationType, decimal amount)
        {
            return true;
        }

        public string GetClient(string clientAccount)
        {
            return "Rubert";
        }

        public bool Retirement(string originAccount, string identification, IdentificationTypeEnum identificationType, decimal amount)
        {
            return true;
        }

        public bool Validate(string account)
        {
            return true;
        }

        public bool Validate(string identification, IdentificationTypeEnum identificationType)
        {
            return true;
        }
    }
}
