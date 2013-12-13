using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    [Serializable]
    public class Book
    {
        public Book() { }
        #region 公有变量
        public int bkID { get; set; }
        public string bkCode { get; set; }
        public string bkName { get; set; }
        public string bkAuthor { get; set; }
        public string bkPress { get; set; }
        public DateTime bkdatePress { get; set; }
        public string bkISBN { get; set; }
        public string bkCatalog { get; set; }
        public string bkLanguage { get; set; }
        public int bkPages { get; set; }
        public float bkPrice { get; set; }
        public DateTime bkDateIn { get; set; }
        public int bkNum { get; set; }
        public string bkBrief { get; set; }
        public Byte[] bkCover { get; set; }
        public string bkStatus { get; set; }
        #endregion

        //添加复制函数
        public Book(Book rt)
        {
            this.bkID = rt.bkID;
            this.bkCode = rt.bkCode;
            this.bkName = rt.bkName;
            this.bkAuthor = rt.bkAuthor;
            this.bkPress = rt.bkPress;
            this.bkdatePress = rt.bkdatePress;
            this.bkISBN = rt.bkISBN;
            this.bkCatalog = rt.bkCatalog;
            this.bkLanguage = rt.bkLanguage;
            this.bkPages = rt.bkPages;
            this.bkPrice = rt.bkPrice;
            this.bkDateIn = rt.bkDateIn;
            this.bkNum = rt.bkNum;
            this.bkBrief = rt.bkBrief;
            this.bkCover = rt.bkCover;
            this.bkStatus = rt.bkStatus;
        }

        #region 设置DataGridView 标题
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "bkID": sTitle = "图书序号"; break;
                case "bkCode": sTitle = "图书编号"; break;
                case "bkName": sTitle = "图书名称"; break;
                case "bkAuthor": sTitle = "图书作者"; break;
                case "bkPress": sTitle = "出版社名"; break;
                case "bkdatePress": sTitle = "出版日期"; break;
                case "bkISBN": sTitle = "标准ISBN"; break;
                case "bkCatalog": sTitle = "名称分类"; break;
                case "bkLanguage": sTitle = "所属语种"; break;
                case "bkPages": sTitle = "图书页数"; break;
                case "bkPrice": sTitle = "图书价格"; break;
                case "bkDateIn": sTitle = "入馆日期"; break;
                case "bkNum": sTitle = "图书本数"; break;
                case "bkBrief": sTitle = "图书状态"; break;
                case "bkCover": sTitle = "图书简介"; break;
                case "bkStatus": sTitle = "图书封面"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
