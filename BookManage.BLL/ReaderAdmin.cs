using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    class ReaderAdmin
    {
        public Reader GetReader(int rdID)
        {
            return (DAL.ReaderDAL.GetObjectByID(rdID));
        }
    }
}
