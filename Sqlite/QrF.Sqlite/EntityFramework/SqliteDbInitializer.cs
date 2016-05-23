﻿using QrF.Sqlite.Contract;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrF.Sqlite.EntityFramework
{
    public class SqliteDbInitializer : SqliteDropCreateDatabaseWhenModelChanges<SqliteDbContext>
    {
        public SqliteDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder, typeof(CustomHistory))
        { }

        protected override void Seed(SqliteDbContext context)
        {
            context.Set<User>().Add(new User
            {
                UserName = "Admin",
                Password = "123456"
            });

            context.Set<Customer>().Add(new Customer
            {
                BuyTime = DateTime.Now,
                Name = "测试",
                Days=10,
                Money=1000,
                Product="测试产品",
                Card="",
                CarrayDate=DateTime.Now,
                DueDate=DateTime.Now
            });
        }
    }
}