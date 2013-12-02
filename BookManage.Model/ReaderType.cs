using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    ///<summary>
    ///实体类ReaderType
    ///</summary>
    [Serializable]

    public class ReaderType
    {
        public ReaderType() { }
        //C# code in VS 2008 or 2010,can do like this.
        #region 公有属性
        public int rdType { get; set; }
        public string rdTypeName { get; set; }
        public int CanLendQty { get; set; }
        public int CanLendDay { get; set; }
        public int CanContinueTimes { get; set; }
        public float PunishRate { get; set; }
        public int DateValid { get; set; }
        #endregion

        //添加复制函数
        public ReaderType(ReaderType rt)
        {
            this.rdType = rt.rdType;
            this.rdTypeName = rt.rdTypeName;
            this.CanLendQty = rt.CanLendQty;
            this.CanLendDay = rt.CanLendDay;
            this.CanContinueTimes = rt.CanContinueTimes;
            this.PunishRate = rt.PunishRate;
            this.DateValid = rt.DateValid;
        }
    }
}
