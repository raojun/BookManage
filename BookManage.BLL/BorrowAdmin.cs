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
        //dgvBook指定行操作
        public static Borrow GetBookInformation(int bkID)
        {
            return (BorrowDAL.GetObjectByID(bkID));
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

        //借书
        public  int Insert(Borrow borrow)
        {
            return (BorrowDAL.Insert(borrow));
        }

        //显示所借书信息
        public  DataTable GetBorrow(int rdID)
        {
            return (BorrowDAL.GetBorrow(rdID));
        }

        //获取读者信息
        public DataTable GetReader(int rdID)
        {
            return (BorrowDAL.GetReader(rdID));
        }
    }
}
