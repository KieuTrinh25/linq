using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSQLServer.dao
{
    public abstract class DatabaseDao
    {
        //Singleton
        private static DatabaseDao instance;
        public static void init(DatabaseDao _instance)
        {
            instance = _instance;
        }
        public static DatabaseDao Instance()
        {
            return instance;
        }
        abstract public UserDao GetUserDao();
    }
}
