﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DatabaseProject.Models;
using DatabaseProject.Repositories;

namespace CashBox.Services
{
    public class CashService : ICashService
    {
        private readonly IIntegrationLayer _integrationLayer;

        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;
        private BaseRepository<MCoin> _mcoinRepository;

        public CashService()
        {
            _integrationLayer = new IntegrationLayer();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();
            _mcoinRepository = unitOfWork.Repository<MCoin>();
        }

        public void Deposit(Transaction transaction, Dto.FrmDepositDto frmDepositDto)
        {
            if (_integrationLayer.Validate(transaction.Identification, transaction.IdentificationType.Value))
            {
                if (_integrationLayer.Validate(transaction.OriginAccount))
                {
                    if (_integrationLayer.Validate(transaction.DestinyAccount))
                    {
                        if (_integrationLayer.Deposit(transaction.OriginAccount, transaction.DestinyAccount, transaction.Identification, transaction.IdentificationType.Value, transaction.Amount))
                        {
                            transaction.Status = TransactionStatusEnum.Completed;

                            string clientFullName = _integrationLayer.GetClient(transaction.OriginAccount);
                            MessageBox.Show($"El cliente {clientFullName}, Portador de la cedula [{ transaction.Identification }] y de numero de cuenta [{ transaction.OriginAccount}] realizo un deposito de [{ transaction.Amount } " +
                                $"pesos] a la cuenta [{ transaction.DestinyAccount }]");
                        }
                        else
                        {
                            transaction.Status = TransactionStatusEnum.Incompleted;
                            MessageBox.Show("Su trasmsaccion ha sido efectuada correctamente. Estaremos dandole seguimeiento a esta transacción " +
                                "por motivos internos.");
                        }

                        if (transaction.Id != 0)
                        {
                            var currentTransaction = _transactionRepository.GetById(transaction.Id);
                            currentTransaction.Status = transaction.Status;
                            _transactionRepository.Update(currentTransaction);
                        }
                        else
                        {
                            _transactionRepository.Insert(transaction);

                            var mcCOins = frmDepositDto.CoinElements.Select(e => new MCoin()
                            {
                                Value = e
                            }).ToList();

                            _mcoinRepository.InsertAll(mcCOins);

                        }
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

        public void Retirement(Transaction transaction, List<MCoin> coinsAdded)
        {
            if (_integrationLayer.Validate(transaction.Identification, transaction.IdentificationType.Value))
            {
                if (_integrationLayer.Validate(transaction.OriginAccount))
                {
                    if (_integrationLayer.Retirement(transaction.OriginAccount, transaction.Identification, transaction.IdentificationType.Value, transaction.Amount))
                    {
                        transaction.Status = TransactionStatusEnum.Completed;

                        string clientFullName = _integrationLayer.GetClient(transaction.OriginAccount);

                        MessageBox.Show($"El cliente {clientFullName}, Portador de la cedula [{ transaction.Identification }] y de numero de cuenta [{ transaction.OriginAccount }] realizo un retiro de [{ transaction.Amount } pesos] de la cuenta [{ transaction.OriginAccount }]");
                    }
                    else
                    {
                        transaction.Status = TransactionStatusEnum.Incompleted;
                        MessageBox.Show("Su trasmsaccion ha sido efectuada correctamente. Estaremos dandole seguimeiento a esta transacción " +
                            "por motivos internos.");

                    }

                    if (transaction.Id != 0)
                    {
                        var t = _transactionRepository.GetById(transaction.Id);
                        t.Status = transaction.Status;
                        _transactionRepository.Update(t);
                    }
                    else
                    {
                        _transactionRepository.Insert(transaction);
                        _mcoinRepository.DeleteAll(coinsAdded);
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

    }
}
