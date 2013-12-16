using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class BookAdmin//图书管理类
    {
        public static Book GetBook(int bkID)
        {
            return (BookDAL.GetObjectByID(bkID));
        }

        public int Insert(Book book)
        {
            return (BookDAL.Insert(book));
        }

        public int Delete(Book book)
        {
            return (BookDAL.Delete(book));
        }

        public int Update(Book book)
        {
            return (BookDAL.Update(book));
        }

        public DataTable GetBook()
        {
            return (BookDAL.GetBook());
        }

        public DataTable GetBook(int bkID, string bkCode, string bkName, string bkAuthor, string bkPress)
        {
            return (BookDAL.GetBook(bkID, bkCode, bkName, bkAuthor, bkPress));
        }
    }
}
