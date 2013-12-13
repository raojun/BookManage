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
        public int bkLanguage { get; set; }
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
    }
}
