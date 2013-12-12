using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManage.DAL;
using BookManage.Model;

namespace BookManage.BLL
{
    public class BookAdmin//图书管理类
    {
        public int Insert(Book book)
        {
            return (BookDAL.Insert(book));
        }
    }
}
