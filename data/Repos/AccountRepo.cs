using Data.Interfaces;
using Data.EFModels;
using Domain.Models;
namespace Data.Repos
{
    public class AccountRepo : IAccountRepo
    {
        private readonly BankAppDataContext db;

        public AccountRepo(BankAppDataContext db)
        {
            this.db = db;
        }
        public int Create(Account entity)
        {
            db.Accounts.Add(entity);
            db.SaveChanges();
            return entity.AccountId;
        }

        public void Delete(int id)
        {
            Account account = db.Accounts.Find(id);
            db.Remove(account);
            db.SaveChanges();
        }

        public Account Get(int id)
        {
            Account account = db.Accounts.Find(id);
            db.SaveChanges();
            return account;
        }

        public void Update(Account entity)
        {
            Account oldAccount = db.Accounts.Find(entity.AccountId);
            db.Entry(oldAccount).OriginalValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}

