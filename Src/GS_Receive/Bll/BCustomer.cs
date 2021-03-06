﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CZZD.GSZX.R.IDAL;
using CZZD.GSZX.R.DALFactory;
using CZZD.GSZX.R.Model;

namespace CZZD.GSZX.R.Bll
{
    public class BCustomer
    {
        private ICustomer dal = DataAccess.CreateCustomerManage();

        public BCustomer()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(decimal USER_ID)
        {
            return dal.Exists(USER_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BaseCustomerTable model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(BaseCustomerTable model)
        {
            return dal.Update(model);
        }

        #endregion  Method
    }//end class
}
