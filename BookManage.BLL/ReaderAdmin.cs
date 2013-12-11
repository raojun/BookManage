using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class ReaderAdmin//读者管理类
    {
        public static Reader GetReader(int rdID)
        {
            return (DAL.ReaderDAL.GetObjectByID(rdID));
        }

        public DataTable  GetAllReaderType()
        {
            return (ReaderTypeDAL.GetAll());
        }

        public DataTable GetReader(int rdType, string rdDept, string rdName)
        {
            return (ReaderDAL.GetReader(rdType, rdDept, rdName));
        }

        public int Update(Reader reader)
        {
            return (ReaderDAL.Update(reader));
        }
    }
}
