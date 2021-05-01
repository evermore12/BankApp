using System;
using Domain.Models;
using Data.Interfaces;
namespace Data.Repos
{
    public class TransactionRepo : ITransactionRepo
    {
        public TransactionRepo()
        {
        }

        public int Create(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Transaction Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
