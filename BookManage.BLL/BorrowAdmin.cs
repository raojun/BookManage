using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class BorrowAdmin//借阅管理类
    {
        //按序号查找
        public DataTable GetBookID(int bkID)
        {
            return (BorrowDAL.GetBookID(bkID));
        }
        //按书名查找
        public  DataTable GetBookName(string bkName)
        {
            return (BorrowDAL.GetBookName(bkName));
        }
    }
}
