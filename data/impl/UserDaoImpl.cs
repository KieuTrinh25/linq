using LinqSQLServer.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSQLServer.impl
{
    public class UserDaoImpl : UserDao
    {
        private string connectString = "Data Source=LAPTOP-C1096QJI\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True";
        private ShopDataContext db;
        public UserDaoImpl()
        {
            db = new ShopDataContext(connectString);
        }

        public int count()
        {
            var userList = (List<user>)from user in db.GetTable<user>() select user;
            return userList.Count();
        }

        public void deleteById(int id)
        {
            user find = db.users.Single(us => us.id == id);
            db.users.DeleteOnSubmit(find);
            db.SubmitChanges();
        }

        public List<user> findAll()
        {
            var userList = (List<user>) from user in db.GetTable<user>() select user;
            return userList;
        }

        public user findById(int id)
        {
            return db.users.Single(us => us.id == id);
        }

        public void insert(user user)
        {
            db.users.InsertOnSubmit(user);
            db.SubmitChanges();
        }

        public void update(user user)
        {
            user find = db.users.Single(us => us.id == id);
            find.phone = user.phone;
            find.orders = user.orders;
            find.password  = user.password;
            db.SubmitChanges();
        }
    }
}
