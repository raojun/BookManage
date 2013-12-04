using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    [Serializable]
    public class Reader
    {
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

        public Reader(Reader rt)
        {
            this.rdID = rt.rdID;
            this.rdName = rt.rdName;
            this.rdSex = rt.rdSex;
            this.rdType = rt.rdType;
            this.rdDept = rt.rdDept;
            this.rdPhone = rt.rdPhone;
            this.rdEmail = rt.rdEmail;
            this.rdDateReg = rt.rdDateReg;
            this.rdPhoto = rt.rdPhoto;
            this.rdStatus = rt.rdStatus;
            this.rdBorrowQty = rt.rdBorrowQty;
            this.rdPwd = rt.rdPwd;
            this.rdAdminRoles = rt.rdAdminRoles;
        }
    }
}
