using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskUWP.Models;
namespace TestTaskUWP.Models
{
    public class Repository
    {
        public void SaveTransaction(Transaction model)
        {
            using (var db = new TransactionContext())
            {
                if (model.id_Transaction > 0)
                {
                    db.Attach(model);
                    db.Update(model);
                }
                else
                {
                    db.Add(model);
                }
                db.SaveChanges();
            }
        }
        

        public Transaction LoadTransaction()
        {
            using(var db = new TransactionContext())
            {
                return (from t in db.Transactions select t).FirstOrDefault();
            }
        }

        public List<Transaction> GetAllTransaction()
        {

            using (TransactionContext db = new TransactionContext())
            {
                return db.Transactions.ToList();
                
            }
        }
    }
}
