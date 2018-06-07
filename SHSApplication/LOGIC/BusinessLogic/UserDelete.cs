using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public static class UserDelete
    {
        public static async Task Delete(People person)
        {
            using (var db = new SHSdb())
            {
                People existing =  db.peoples.FirstOrDefault(x => x.EmailAddress == person.EmailAddress);
                if (existing == null) { throw new KeyNotFoundException(); }
                db.peoples.DeleteOnSubmit(existing);
                db.SubmitChanges();
            }
        }
    }
}
