using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    public class Reader
    {
        [Serializable]

        public Reader() { }
        #region 公有属性
        public int rdID { get; set; }
        public string rdName { get; set; }
        public string rdSex { get; set; }
        public int rdType { get; set; }
        public string rdDept { get; set; }
        public string rdPhone { get; set; }
        public string rdEmail { get; set; }
        public DateTime rdDateReg { get; set; }
        public Byte[] rdPhoto { get; set; }
        public string rdStatus { get; set; }
        public int rdBorrowQty { get; set; }
        public string rdPwd { get; set; }
        public int rdAdminRoles { get; set; }
        #endregion
    }
}
