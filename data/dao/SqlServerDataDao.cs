using LinqSQLServer.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSQLServer.dao
{
    public class SqlServerDataDao : DataDao
    {
        public override UserDao GetUserDao()
        {
            return new UserDaoImpl();
        }
    }
}
