//实现对应数据表的查删改查等操作，以及存储过程的调用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BookManage.Model;

namespace BookManage.DAL
{
    //添加ReaderType表中的插入，删除，修改3个方法
    public class ReaderTypeDAL//读者类型数据表访问类
    {
        //插入
        public static int Insert(ReaderType readertype)
        {
            int rows = 0;
            string sql = "insert into ReadType(rdType,rdTypeName,CanLendQty,CanLendDay,CanContinueTimes,PunishRate,DateValid)"
                             + "values (@rdType,@rdTypeName,@CanLendQty,@CanLendDay,@CanContinueTimes,@PunishRate,@DateValid)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@rdType",readertype.rdType),
                                           new SqlParameter("@rdTypeName",readertype.rdTypeName),
                                           new SqlParameter("@CanLendQty",readertype.CanLendQty),
                                           new SqlParameter("@CanLendDay",readertype.CanLendDay),
                                           new SqlParameter("@CancontinueTimes",readertype.CanContinueTimes),
                                           new SqlParameter("@PunishRate",readertype.PunishRate),
                                           new SqlParameter("@DateValid",readertype.DateValid)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        //删除
        public static int Delete(ReaderType readertype)
        {
            int rows = 0;
            string sql = "deaete from ReaderType where rdType=@rdType";
            SqlParameter[] parameters = { new SqlParameter("@rdType", readertype.rdType) };
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
        //更新
        public static int Update(ReaderType readertype)
        {
            int rows = 0;
            string sql = "update ReaderType set"
                + "rdTypeName=@rdTypeName,"
                + "CanLendQty=@CanLendQty,"
                + "CanLendDay=@CanLendDay,"
                + "ContinueTimes=@ContinueTimes,"
                + "PunishRate=@PunishRate,"
                + "DateValid=@DateValid"
                + "where rdType=@rdType";
            SqlParameter[] parameters ={
                                           new SqlParameter("@rdTypeName",readertype.rdTypeName),
                                           new SqlParameter("@CanLendQty",readertype.CanLendQty),
                                           new SqlParameter("@CanLendDay",readertype.CanLendDay),
                                           new SqlParameter("@CancontinueTimes",readertype.CanContinueTimes),
                                           new SqlParameter("@PunishRate",readertype.PunishRate),
                                           new SqlParameter("@DateValid",readertype.DateValid),
                                           new SqlParameter("@rdType",readertype.rdType)
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
        ///
        /// 由读者类型ID(rdType)得到该读者类型信息，返回DataRow
        ///
        public static DataRow GetDRByID(int rdType)
        {
            string sql = "select * from ReaderType where rdType=@rdType";
            SqlParameter[] parameters = { new SqlParameter("@rdType)", rdType) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "ReaderType");
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

        public static ReaderType GetObjectByID(int rdType)
        {
            DataRow dr = GetDRByID(rdType);
            return SqlHelper.DataRowToT<ReaderType>(dr);
        }


        public static DataTable GetAll()
        {
            string sql = "select * from ReaderType";
            return SqlHelper.GetDataTable(sql, null, "ReaderType");
        }
    }
}
