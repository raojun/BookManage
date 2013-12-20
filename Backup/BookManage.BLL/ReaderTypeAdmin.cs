using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class ReaderTypeAdmin//读者类型管理类
    {
        public static ReaderType GetReaderType(string rdType)
        {
            return (ReaderTypeDAL.GetObjectByID(rdType));
        }

        public DataTable GetReaderType()
        {
            return (ReaderTypeDAL.GetReaderType());
        }

        public int Insert(ReaderType readertype)
        {
            return (ReaderTypeDAL.Insert(readertype));
        }

        public int Update(ReaderType readertype)
        {
            return (ReaderTypeDAL.Update(readertype));
        }
        public int Delete(ReaderType readertype)
        {
            return (ReaderTypeDAL.Delete(readertype));
        }
    }
}
