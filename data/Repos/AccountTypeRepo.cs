using Data.Interfaces;
using Data.EFModels;
using Domain.Models;
namespace Data.Repos
{
    public class AccountTypeRepo : IAccountTypeRepo
    {
        private readonly BankAppDataContext db;

        public AccountTypeRepo(BankAppDataContext db)
        {
            this.db = db;
        }
        public int Create(AccountType entity)
        {
            db.AccountTypes.Add(entity);
            db.SaveChanges();
            return entity.AccountTypeId;
        }

        public void Delete(int id)
        {
            AccountType accountType = db.AccountTypes.Find(id);
            db.Remove(accountType);
            db.SaveChanges();
        }

        public AccountType Get(int id)
        {
            AccountType accountType = db.AccountTypes.Find(id);
            db.SaveChanges();
            return accountType;
        }

        public void Update(AccountType entity)
        {
            AccountType oldAccountType = db.AccountTypes.Find(entity.AccountTypeId);
            db.Entry(oldAccountType).OriginalValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}

