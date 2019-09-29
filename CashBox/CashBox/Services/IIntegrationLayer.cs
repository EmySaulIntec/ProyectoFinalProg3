using DatabaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBox.Services
{
    public interface IIntegrationLayer
    {
        bool Validate(string account);
        bool Validate(string identification, IdentificationTypeEnum identificationType);
    }
}
