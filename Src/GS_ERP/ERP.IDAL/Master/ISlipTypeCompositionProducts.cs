﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CZZD.ERP.IDAL
{
    public interface ISlipTypeCompositionProducts
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists( string slipTypeCode, string compositionProductsCode);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        void Add(CZZD.ERP.Model.BaseSlipTypeCompositionProductsTable model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZZD.ERP.Model.BaseSlipTypeCompositionProductsTable model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(string slipTypeCode, string compositionProductsCode);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        CZZD.ERP.Model.BaseSlipTypeCompositionProductsTable GetModel(string slipTypeCode, string compositionProductsCode);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);

        int GetRecordCount(string strWhere);

        System.Data.DataSet GetList(string strWhere, string orderby, int startIndex, int endIndex);
        #endregion  成员方法
    }
}
