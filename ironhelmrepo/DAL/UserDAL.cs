﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iron_helm_order_mgt.Entities;

namespace Iron_helm_order_mgt.DAL
{
    public class UserDAL
    {
        IronHelmDbContext context;

        public UserDAL()
        {
            this.context = new IronHelmDbContext();
        }

        public DataTable loginByUserNameAndPassword(User user_)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("userId", typeof(string));
            dt.Columns.Add("userType", typeof(string));
            dt.Columns.Add("password", typeof(string));
            var query = from user in context.Users.AsEnumerable()
                        where user.userId == user_.userId
                        && user.password== user_.password
                        select dt.LoadDataRow(new object[] {
                            user.userId,
                            user.userType,
                            user.password
                            }, false);
            if (query != null && query.Any())
            { 
                query?.CopyToDataTable();
           }


            return dt;
        }
    }
}
