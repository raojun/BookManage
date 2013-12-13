using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BookManage.Model; 

namespace BookManage.DAL
{
    public class BookDAL//图书数据访问类
    {
        public static int Insert(Book book)
        {
            int rows = 0;
            string sql = "insert into Book(bkID,bkCode,bkName,bkAuthor,bkPress,bkdatePress,bkISBN,bkCatalog,bkLanguage,bkPages,bkPrice,bkDateIn,bkNum,bkBrief,bkCover,bkStatus)"
                             + "values (@bkID,@bkCode,@bkName,@bkAuthor,@bkPress,@bkdatePress,@bkISBN,@bkCatalog,@bkLanguage,@bkPages,@bkPrice,@bkDateIn,@bkNum,@bkBrief,@bkCover,@bkStatus)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkID",book.bkID),
                                           new SqlParameter("@bkCode",book.bkCode),
                                           new SqlParameter("@bkName",book.bkName),
                                           new SqlParameter("@bkAuthor",book.bkAuthor),
                                           new SqlParameter("@bkPress",book.bkPress),
                                           new SqlParameter("@bkdatePress",book.bkdatePress),
                                           new SqlParameter("@bkISBN",book.bkISBN),
                                           new SqlParameter("@bkCatalog",book.bkCatalog),
                                           new SqlParameter("@bkLanguage",book.bkLanguage),
                                           new SqlParameter("@bkPages",book.bkPages),
                                           new SqlParameter("@bkPrice",book.bkPrice),
                                           new SqlParameter("@bkDateIn",book.bkDateIn),
                                           new SqlParameter("@bkNum",book.bkNum),
                                           new SqlParameter("@bkBrief",book.bkBrief),
                                           new SqlParameter("@bkCover",book.bkCover),
                                           new SqlParameter("@bkStatus",book.bkStatus)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        public static int Update(Book book)
        {
            int rows = 0;
            string sql = "update Book set"
                + "bkID=@bkID,"
                + "bkCode=@bkCode,"
                + "bkName=@bkName,"
                + "bkAuthor=@bkAuthor,"
                + "bkPress=@bkPress,"
                + "bkdatePress@bkdatePress,"
                + "bkISBN=@bkISBN,"
                + "bkCatalog=@bkCatalog,"
                + "bkLanguage=@bkLanguage,"
                + "bkPages=@bkPages,"
                + "bkPrice=@bkPrice,"
                + "bkDateIn=@bkDateIn,"
                + "bkNum=@bkNum,"
                + "bkBrief=@bkBrief,"
                + "bkCover=@bkCover,"
                + "bkStatus=@bkStatus"
                + "where bkID=@bkID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkID",book.bkID),
                                           new SqlParameter("@bkCode",book.bkCode),
                                           new SqlParameter("@bkName",book.bkName),
                                           new SqlParameter("@bkAuthor",book.bkAuthor),
                                           new SqlParameter("@bkPress",book.bkPress),
                                           new SqlParameter("@bkdatePress",book.bkdatePress),
                                           new SqlParameter("@bkISBN",book.bkISBN),
                                           new SqlParameter("@bkCatalog",book.bkCatalog),
                                           new SqlParameter("@bkLanguage",book.bkLanguage),
                                           new SqlParameter("@bkPages",book.bkPages),
                                           new SqlParameter("@bkPrice",book.bkPrice),
                                           new SqlParameter("@bkDateIn",book.bkDateIn),
                                           new SqlParameter("@bkNum",book.bkNum),
                                           new SqlParameter("@bkBrief",book.bkBrief),
                                           new SqlParameter("@bkCover",book.bkCover),
                                           new SqlParameter("@bkStatus",book.bkStatus)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        public static int Delete(Book book)
        {
            int rows = 0;
            string sql = "deaete from Book where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", book.bkID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        ///
        /// 由读者类型ID(rdType)得到该读者类型信息，返回DataRow
        ///
        public static DataRow GetDRByID(int bkID)
        {
            string sql = "select * from Book where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", bkID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "Book");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
            {
                return dr;
            }
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }

        public static Book GetObjectByID(int bkID)
        {
            DataRow dr = GetDRByID(bkID);
            return SqlHelper.DataRowToT<Book>(dr);
        }

        public static DataTable GetBook()
        {
            string sql;
            sql = "select * from Book";
            return SqlHelper.GetDataTable(sql, null, "Book");
        }
    }
}
