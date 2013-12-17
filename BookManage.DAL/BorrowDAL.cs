using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BookManage.Model;

namespace BookManage.DAL
{
    public class BorrowDAL//借阅数据表访问类
    {
        //借书时在Borrow表内插入一条记录
        public static int Insert(Borrow borrow)
        {

            int rows = 0;
            string sql = "insert into Borrow(rdID,bkID,IdContinueTimes,IdDateOut,IdDateRetPlan,IdDateRetAct,IdOverDay,IdOverMoney,IdPunishMoney,IsHasReturn,OperatorLend,OperatorRet)"
                             + " values (@rdID,@bkID,@IdContinueTimes,@IdDateOut,@IdDateRetPlan,@IdDateRetAct,@IdOverDay,@IdOverMoney,@IdPunishMoney,@IsHasReturn,@OperatorLend,@OperatorRet)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@rdID",borrow.rdID),
                                           new SqlParameter("@bkID",borrow.bkID),
                                           new SqlParameter("@IdContinueTimes",borrow.IdContinueTimes),
                                           new SqlParameter("@IdDateOut",borrow.IdDateOut),
                                           new SqlParameter("@IdDateRetPlan",borrow.IdDateRetPlan),
                                           new SqlParameter("@IdDateRetAct",borrow.IdDateRetAct),
                                           new SqlParameter("@IdOverDay",borrow.IdOverDay),
                                           new SqlParameter("@IdOverMoney",borrow.IdOverMoney),
                                           new SqlParameter("@IdPunishMoney",borrow.IdPunishMoney),
                                           new SqlParameter("@IsHasReturn",borrow.IsHasReturn),
                                           new SqlParameter("@OperatorLend",borrow.OperatorLend),
                                           new SqlParameter("@OperatorRet",borrow.OperatorRet)
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

        //借书后更新图书馆书籍数量和状态
        public static  int UpdateBook(Borrow borrow)
        {
            int rows = 0;
            string sql="update Book set bkNum=bkNum-1,bkStatus='借出' where bkID=@bkID";
            SqlParameter [] parameters={
                                           new SqlParameter("@bkID",borrow.bkID)
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

        //续借时更新借书信息
        public static int UpdateContinue(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Borrow set "
                + "IdContinueTimes=@IdContinueTimes+1,"
                + "IdDateOut=@IdDateOut "
                + "where bkID=@bkID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkID",borrow.bkID),
                                           new SqlParameter("@IdContinueTimes",borrow.IdContinueTimes),
                                           new SqlParameter("@IdDateOut",borrow.IdDateOut)
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

        //还书时更新借书信息
        public static int UpdateBack(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Borrow set "
                + "IdContinueTimes=0,"
                + "IdDateRetAct=@IdDateRetAct, "
                + "IsHasReturn=1 "
                + " where bkID=@bkID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkID",borrow.bkID),
                                           new SqlParameter("@IdDateRetAct",borrow.IdDateRetAct)
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

        //还书时更新图书信息
        public static int UpdateBk(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Book set bkNum=bkNum+1,bkStatus='在馆' where bkID=@bkID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkID",borrow.bkID)
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

        public static int Delete(Borrow borrow)
        {
            int rows = 0;
            string sql = "deaete from Borrow where BorrowID=@BorrowID";
            SqlParameter[] parameters = { new SqlParameter("@BorrowID", borrow.BorrowId) };
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

        //dgvBook内按bkID查找图书
        public static DataTable GetBookID(int bkID)
        {
            string sql = "select * from Book where bkID=@bkID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkID",bkID)
                                      };
            return SqlHelper.GetDataTable(sql, parameters, "Book");
        }

        //dgvBook内按bkName查找图书
        public static DataTable GetBookName(string bkName)
        {
            bkName = (bkName == "") ? ("%") : ("%" + bkName + "%");
            string sql = "select * from Book where bkName like @bkName";
            SqlParameter[] parameters ={
                                           new SqlParameter("@bkName",bkName)
                                      };
            return SqlHelper.GetDataTable(sql, parameters, "Book");
        }

        ///
        /// 由读者类型ID(rdType)得到该读者类型信息，返回DataRow
        ///
        public static DataRow GetDRByID(int BorrowID)
        {
            string sql = "select * from Borrow where BorrowID=@BorrowID";
            SqlParameter[] parameters = { new SqlParameter("@BorrowID", BorrowID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "Borrow");
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

        public static Borrow GetObjectByID(int BorrowID)
        {
            DataRow dr = GetDRByID(BorrowID);
            return SqlHelper.DataRowToT<Borrow>(dr);
        }

        //dgvBorrow内显示所借书信息
        public static DataTable GetBorrow(int rdID)
        {
            string sql;
            if (rdID == 0)
            {
                return null;
            }
            else
            {
                sql = "select Book.bkID,Book.bkName,Book.bkAuthor,Borrow.IdContinueTimes,Borrow.IdDateOut,Borrow.IdDateRetPlan,Borrow.IdOverDay,Borrow.IdOverMoney "
                        + "from Book, Borrow  where Book.bkID=Borrow.bkID and Borrow.rdID=@rdID and Borrow.IsHasReturn=0";
                SqlParameter[] parameters ={
                                              new SqlParameter ("@rdID",rdID)
                                          };
                return SqlHelper.GetDataTable(sql,parameters , "Book");
            }
        }

        /// <summary>
        /// 获取读者信息
        /// </summary>
        /// <param name="rdID"></param>
        /// <returns></returns>
       public static DataTable GetReader(int rdID)
       {
           string sql;

           if (rdID == 0)
           {
               return null;
           }
           else
           {
               sql = "select * from Reader where rdID=@rdID";
               SqlParameter[] parameters ={
                                             new  SqlParameter ("@rdID",rdID)
                                          };
               return SqlHelper.GetDataTable(sql, parameters, "Reader");
           }
       }

        /// <summary>
        /// 查询所借书信息
        /// </summary>
        /// <param name="rdID"></param>
        /// <returns></returns>
       public static DataTable GetBorrowBook(int rdID)
       {
           string sql = "select * from Borrow where rdID=@rdID";
           SqlParameter[] parameters ={
                                             new  SqlParameter ("@rdID",rdID)
                                          };
           return SqlHelper.GetDataTable(sql, parameters, "Borrow");
       }
    }
}
