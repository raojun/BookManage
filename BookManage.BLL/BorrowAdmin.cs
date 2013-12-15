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
        public static Borrow GetBook(int rdID)
        {
            return (BorrowDAL.GetObjectByID(rdID));
        }
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

        public static int Update(Borrow borrow)
        {
            return (BorrowDAL.Update(borrow));
        }

        public  DataTable GetBorrow(int rdID)
        {
            return (BorrowDAL.GetBorrow(rdID));
        }

        public DataTable GetReader(int rdID)
        {
            return (BorrowDAL.GetReader(rdID));
        }

        public DataTable GetBorrowBook(int rdID)
        {
            return (BorrowDAL.GetBorrowBook(rdID));
        }
    }
}
