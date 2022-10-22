using LinqSQLServer.dao;
using LinqSQLServer.data.dao;
using LinqSQLServer.data.impl.api;
using System;
using System.Linq;

namespace LinqSQLServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectString = "Data Source=LAPTOP-C1096QJI\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True";
            //ShopDataContext db = new ShopDataContext(connectString);

            //DataDao.init(new SqlServerDataDao());
            DataDao.init(new ApiDataDao());


            UserDao userDao = DataDao.Instance().GetUserDao();
            List<user> userList = userDao.findAll();
        }
    }
}