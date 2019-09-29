using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
using ProyectoFinalProg3;

namespace CashBox.Services
{
    public class CashService : ICashService
    {
        private readonly IIntegrationLayer _integrationLayer;

        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;
        public CashService()
        {
            _integrationLayer = new IntegrationLayer();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();
        }

        public void Deposit(Transaction transaction)
        {
            if (_integrationLayer.Validate(transaction.Identification, transaction.IdentificationType))
            {
                if (_integrationLayer.Validate(transaction.OriginAccount))
                {
                    if (_integrationLayer.Validate(transaction.DestinyAccount))
                    {
                        if (_integrationLayer.Deposit(transaction.OriginAccount, transaction.DestinyAccount, transaction.Identification, transaction.IdentificationType, transaction.Amount))
                        {
                            transaction.Status = TransactionStatusEnum.Completed;
                            Settings.AddToCash(transaction.Amount);

                            string clientFullName = _integrationLayer.GetClient(transaction.OriginAccount);
                            MessageBox.Show($"El cliente {clientFullName}, Portador de la cedula [{ transaction.Identification }] y de numero de cuenta [{ transaction.OriginAccount}] realizo un deposito de [{ transaction.Amount } " +
                                $"pesos] a la cuenta [{ transaction.DestinyAccount }]");
                        }
                        else
                        {
                            transaction.Status = TransactionStatusEnum.Incompleted;
                            MessageBox.Show("Transaccion no efectuada, intentelo mas tarde. Enviada a transacciones fallidas");
                        }

                        if (transaction.Id != 0)
                        {
                            var t = _transactionRepository.GetById(transaction.Id);
                            t.Status = transaction.Status;
                            _transactionRepository.Update(t);
                        }
                        else
                            _transactionRepository.Insert(transaction);
                    }
                    else
                    {
                        MessageBox.Show("El numero de cuenta destino es invalido o no existe");
                    }
                }
                else
                {
                    MessageBox.Show("El numero de cuenta es incorrecto");
                }
            }
            else
            {
                MessageBox.Show("El numero de cedula es incorrecto");
            }
        }

        public void Retirement(Transaction transaction)
        {
            if (_integrationLayer.Validate(transaction.Identification, transaction.IdentificationType))
            {
                if (_integrationLayer.Validate(transaction.OriginAccount))
                {
                    if (_integrationLayer.Retirement(transaction.OriginAccount, transaction.Identification, transaction.IdentificationType, transaction.Amount))
                    {
                        if (!Settings.SubstractToCash(transaction.Amount))
                        {
                            MessageBox.Show("No se puede hacer la transacción caja vacía.");
                            return;
                        }

                        transaction.Status = TransactionStatusEnum.Completed;

                        string clientFullName = _integrationLayer.GetClient(transaction.OriginAccount);

                        MessageBox.Show($"El cliente {clientFullName}, Portador de la cedula [{ transaction.Identification }] y de numero de cuenta [{ transaction.OriginAccount }] realizo un retiro de [{ transaction.Amount } pesos] de la cuenta [{ transaction.OriginAccount }]");
                    }
                    else
                    {
                        transaction.Status = TransactionStatusEnum.Incompleted;
                        MessageBox.Show("Transaccion no efectuada, intentelo mas tarde. Enviada a transacciones fallidas");
                    }

                    if (transaction.Id != 0)
                    {
                        var t = _transactionRepository.GetById(transaction.Id);
                        t.Status = transaction.Status;
                        _transactionRepository.Update(t);
                    }
                    else
                        _transactionRepository.Insert(transaction);
                }
                else
                {

                    MessageBox.Show("El numero de cuenta es incorrecto");
                }
            }
            else
            {
                MessageBox.Show("El numero de cedula es incorrecto");
            }
        }

    }
}
