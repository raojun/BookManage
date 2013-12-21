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

        //借书
        public int Insert(Borrow borrow)
        {
            return (BorrowDAL.Insert(borrow));
        }

        //显示所借书信息
        public DataTable GetBorrow(int rdID)
        {
            return (BorrowDAL.GetBorrow(rdID));
        }

        //获取读者信息
        public DataTable GetReader(int rdID)
        {
            return (BorrowDAL.GetReader(rdID));
        }

        //借书时更新图书信息
        public  int UpdateBook(Borrow borrow)
        {
            return (BorrowDAL.UpdateBook(borrow));
        }

        //借书后更新读者借书本数
        public int UpdateBorrowNum(Reader reader)
        {
            return (BorrowDAL.UpdateBorrowNum(reader));
        }

        //续借时更新borrow表记录
        public int UpdateContinue(Borrow borrow)
        {
            return (BorrowDAL.UpdateContinue(borrow));
        }

        //还书时更新borrow表记录
        public int UpdateBack(Borrow borrow)
        {
            return (BorrowDAL.UpdateBack(borrow));
        }
        //还书时更新所借图书信息
        public int UpdateBk(Borrow borrow)
        {
            return (BorrowDAL.UpdateBk(borrow));
        }

        //根据读者类别rdTye获取可借书天数等信息
        public DataTable GetReaderType(int rdType)
        {
            return (BorrowDAL.GetReaderType(rdType));
        }

        //根据Reader表查询证件状态
        public DataTable GetrdStatus(int rdID)
        {
            return (BorrowDAL.GetrdStatus(rdID));
        }

        //根据Book表查询图书状态
        public DataTable GetbkStatus(int bkID)
        {
            return (BorrowDAL.GetbkStatus(bkID));
        }
    }
}
