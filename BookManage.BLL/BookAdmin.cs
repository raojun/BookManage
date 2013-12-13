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
        public int Insert(Book book)
        {
            return (BookDAL.Insert(book));
        }
        public DataTable GetBook()
        {
            return (BookDAL.GetBook());
        }
    }
}
