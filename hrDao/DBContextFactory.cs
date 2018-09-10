using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using hrModel;

namespace hrDao
{
    public class DBContextFactory
    {
        public static DbContext CreateDBContext()
        {
            DbContext db = (DbContext)CallContext.GetData("context");
            if (db == null)
            {
                db = new hr_dbEntities();
                CallContext.SetData("context", db);
            }
            return db;
        }
    }
}
