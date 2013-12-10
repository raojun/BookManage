using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BookManage.Model;

namespace BookManage.DAL
{
    class BorrowDAL//借阅数据表访问类
    {
        public static int Insert(Borrow borrow)
        {
            int rows = 0;
            string sql = "insert into Borrow(BorrowId,rdID,bkID,IdContinueTimes,IdDateOut,IdDateRetPlan,IdDateRetAct,IdOverDay,IdOverMoney,IdPunishMoney,IsHasReturn,OperatorLend,OperatorRet)"
                             + "value (@BorrowId,@rdID,@bkID,@IdContinueTimes,@IdDateOut,@IdDateRetPlan,@IdDateRetAct,@IdOverDay,@IdOverMoney,@IdPunishMoney,@IsHasReturn,@OperatorLend,@OperatorRet)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@BorrowId",borrow.BorrowId),
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

        public static int Update(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Borrow set"
                + "BorrowId=@rdID,"
                + "rdID=@rdID,"
                + "bkID=@bkID,"
                + "IdcontinueTimes=@IdContinueTimes,"
                + "IdDateOut=@IdDateOut,"
                + "IdDateRetPlan=@IdDateRetPlan,"
                + "IdDateRetAct=@IdDateRetAct,"
                + "IdOverDay=@IdOverDay,"
                + "IdOverMoney=@IdOverMoney,"
                + "IdPunishMoney=@IdPunishMoney,"
                + "IsHasReturn=@IsHasReturn,"
                + "OperatorLend=@OperatorLend,"
                + "OperatorRet=@OperatorRet"
                + "where BorrowID=@BorrowID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@BorrowId",borrow.BorrowId),
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
    }
}
