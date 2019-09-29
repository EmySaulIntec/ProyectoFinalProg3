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
        /// <summary>
        /// Valida un numero de cuenta.
        /// </summary>
        /// <param name="account">Cuenta a validar</param>
        /// <returns>Devuelve true si existe la cuenta</returns>
        bool Validate(string account);

        /// <summary>
        /// Valida a un cliente dado un numero de identififacion y un tipo de identificacion
        /// </summary>
        /// <param name="identification">numero de identificacion con guion: 000-000000000-0</param>
        /// <param name="identificationType">IdentificationTypeEnum : Cedula = 1,  Passport = 2
        /// </param>
        /// <returns>Devuelve true si existe el cliente.</returns>
        bool Validate(string identification, IdentificationTypeEnum identificationType);
        
        /// <summary>
        ///  Consigue el nombre completo del cliente dado un numero de cuenta
        /// </summary>
        /// <param name="clientAccount">Numero de cuenta del ciente</param>
        /// <returns>Nombre completo del cliente</returns>
        string GetClient(string clientAccount);

        /// <summary>
        /// Envia el deposito a la capa de integracion, 
        /// </summary>
        /// <param name="originAccount">Cuenta de donde se esta haciendo el deposito</param>
        /// <param name="destinyAccount">Cuenta a donde se esta haciendo el deposito</param>
        /// <param name="amount">Monto a depositar</param>
        /// <param name="identification">numero de identificacion con guion: 000-000000000-0</param>
        /// <param name="identificationType">IdentificationTypeEnum : Cedula = 1,  Passport = 2
        /// </param>
        /// <returns>Devuelve true si la transaccion (Deposito) fue efectuada</returns>
        bool Deposit(string originAccount, string destinyAccount, string identification, IdentificationTypeEnum identificationType, decimal amount);

        /// <summary>
        /// Envia el retiro a realizar a la capa de integracion, 
        /// </summary>
        /// <param name="originAccount">Cuenta de donde se esta retirando el dinero</param>
        /// <param name="amount">Monto a retirar</param>
        /// <param name="identification">numero de identificacion con guion: 000-000000000-0</param>
        /// <param name="identificationType">IdentificationTypeEnum : Cedula = 1,  Passport = 2
        /// </param>
        /// <returns>Devuelve true si la transaccion (Retiro) fue efectuada</returns>
        bool Retirement(string originAccount, string identification, IdentificationTypeEnum identificationType, decimal amount);
    }
}
