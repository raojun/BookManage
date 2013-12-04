using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    [Serializable]
    public class Borrow
    {
        public Borrow() { }
        #region 公有变量
        public long BorrowId { get; set; }
        public int rdID { get; set; }
        public int bkID { get; set; }
        public int IdContinueTimes { get; set; }
        public DateTime IdDateOut { get; set; }
        public DateTime IdDateRetPlan { get; set; }
        public DateTime IdDateRetAct { get; set; }
        public int IdOverDay { get; set; }
        public float IdOverMoney{get;set;}
        public float IdPunishMoney { get; set; }
        public bool IsHasReturn { get; set; }
        public string OperatorLend { get; set; }
        public string OperatorRet { get; set; }
        #endregion

        //添加复制函数
        public Borrow(Borrow rt)
        {
            this.BorrowId = rt.BorrowId;
            this.rdID = rt.rdID;
            this.bkID = rt.bkID;
            this.IdContinueTimes = rt.IdContinueTimes;
            this.IdDateOut = rt.IdDateOut;
            this.IdDateRetPlan = rt.IdDateRetPlan;
            this.IdDateRetAct = rt.IdDateRetAct;
            this.IdOverDay = rt.IdOverDay;
            this.IdOverMoney = rt.IdOverMoney;
            this.IdPunishMoney = rt.IdPunishMoney;
            this.IsHasReturn = rt.IsHasReturn;
            this.OperatorLend = rt.OperatorLend;
            this.OperatorRet = rt.OperatorRet;
        }
    }
}
