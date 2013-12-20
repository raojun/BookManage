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
        public Byte[ ] rdPhoto { get; set; }
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

        #region 权限设置
        public bool IsLoginAdmin()
        {
            return (rdStatus!="挂失");
        }
        public bool IsUserAdmin()
        {
            return (rdAdminRoles != 0);
        }
        public bool IsReaderAdmin()
        {
            return ((rdAdminRoles & 1) > 0);
        }
        public bool IsBookAdmin()
        {
            return ((rdAdminRoles & 2) > 0);
        }
        public bool IsBorrowAdmin()
        {
            return ((rdAdminRoles & 4) > 0);
        }
        public bool IsSystemAdmin()
        {
            return ((rdAdminRoles & 8) > 0);
        }
        #endregion

        #region 设置DataGridView 标题
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "rdID": sTitle = "借书证号"; break;
                case "rdName": sTitle = "姓    名"; break;
                case "rdSex": sTitle = "性    别"; break;
                case "rdType": sTitle = "读者类别"; break;
                case "rdDept": sTitle = "单    位"; break;
                case "rdPhone": sTitle = "电    话"; break;
                case "rdEmail": sTitle = "邮    箱"; break;
                case "rdDateReg": sTitle = "办证日期"; break;
                case "rdPhoto":sTitle="照    片";break;
                case "rdStatus":sTitle="证件状态";break;
                case  "rdBorrowQty":sTitle="已 借 书";break;
                case "rdPwd":sTitle="密    码";break;
                case "rdAdminRoles":sTitle="管理员角色";break;
            }
            return sTitle;
        }
        #endregion
    }
}
