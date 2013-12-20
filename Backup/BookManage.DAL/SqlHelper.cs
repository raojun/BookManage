using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;
using BookManage.Model;

namespace BookManage.DAL
{
    public class SqlHelper
    {
        #region 字符串加密和解密
        static Byte[] Iv64 = { 22, 27, 31, 53, 53, 66, 97, 33 };
        static Byte[] byKye64 = { 79, 27, 57, 71, 89, 97, 32, 63 };
        ///<summary>
        ///字符串加密
        ///</summary>
        ///<param name="strText">要加密的字符串</param>
        ///<returns></returns>
        private static string Encrypt(string strText)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                Byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKye64, Iv64), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }

        ///<summary>
        ///字符串解密
        ///</summary>
        ///<param name="strText">要解密的字符串</param>
        ///<returns></returns>
        private static string Decrypt(string strText)
        {
            Byte[] inputByteArry = new Byte[strText.Length];
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArry = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKye64, Iv64), CryptoStreamMode.Write);
                cs.Write(inputByteArry, 0, inputByteArry.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        private static string _strConnection = @"Data Source=localhost;Initial Catalog=BookLibrary;User ID=BookAdmin;Password=123;";
        //private static string _strConnection =File.ReadAllText(@"..\..\ConnectionString.txt");
        //public string strConnection
        //{
        //    get { return _strConnection; }
        //    set { _strConnection = value; }
        //}
        private static SqlConnection conn = new SqlConnection(_strConnection);
        //private static SqlConnection conn = new SqlConnection(Decrypt(ConfigurationSettings.AppSettings["connectionstring"]));

        #region 数据库连接的打开与关闭
        //打开数据库连接
        private static void OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch
            {
                throw new Exception("MS SQL Server数据库连接失败！");
            }
        }

        //关闭数据库连接
        private static void CloseConn()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region 执行SQL语句
        ///<summary>
        ///执行简单的非查询SQL语句，返回受影响的记录数
        ///</summary>
        ///<param name="sql">要执行的SQL语句</param>
        ///<returns>受影响的记录数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            int rows = 0;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return rows;
        }

        ///<summary>
        ///执行带参数的非查询SQL语句，返回受影响的记录数
        ///</summary>
        ///<param name="sql">要执行的SQL语句</param>
        ///<param name="parameters">参数集合</param>
        ///<returns>受影响的记录数</returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            int rows = 0;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return rows;
        }


        ///<summary>
        ///执行简单的SQL查询语句，返回结果集中的首行首列，忽略其它行和列。
        ///</summary>
        ///<param name="sql">要执行的SQL查询语句</param>
        ///<returns>返回结果集中的首行首列</returns>
        public static object ExecuteScalar(string sql)
        {
            object obj = null;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return obj;
        }

        ///<summary>
        ///执行带参数的SQL查询语句，返回结果集中的首行首列，忽略其它行和列。
        ///</summary>
        ///<param name="sql">要执行的SQL查询语句</param>
        ///<returns>返回结果集中的首行首列</returns>
        public static object ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            object obj = null;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                obj = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return obj;
        }

        ///<summary>
        ///执行一条带参数的SQL查询语句，返回DataTable对象
        ///</summary>
        ///<param name="sql">SQL查询语句</param>
        ///<param name="TableName">DataSet中的表名</param>
        ///<returns>返回DataTable对象</returns>
        public static DataTable GetDataTable(string sql, SqlParameter[] parameters, string TableName)
        {
            DataTable dt = null;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, TableName);
                dt = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return dt;
        }

        /// <summary>
        /// 执行SQL查询语句，返回查询结果（DataReader对象）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回DataReader对象</returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            SqlDataReader dr = null;
            try
            {
                SqlCommand sqlcom = new SqlCommand(sql, conn);
                OpenConn();
                dr = sqlcom.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return dr;
        }

        ///<summary>
        ///执行带参数的存储过程，返回受影响的行数
        ///</summary>
        ///<param name="storedProcName">存储过程名称</param>
        ///<param name="parameters">存储过程的参数</param>
        ///<returns></returns>
        public static int ExecuteStoredProc(string storedProcName, SqlParameter[] parameters)
        {
            int rows = 0;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcName;
                cmd.Connection = conn;

                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return rows;
        }
        ///<summary>
        ///执行存储过程，返回DataTable对象
        ///</summary>
        ///<param name="sql">存储过程名</param>
        ///<param name="TableName">DataSet中的表名</param>
        ///<returns>返回DataTable对象</returns>
        public static DataTable ExecuteStoredProc(string storedPrecName, SqlParameter[] parameters, string TableName)
        {
            DataTable dt = null;
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedPrecName;
                cmd.Connection = conn;

                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, TableName);
                dt = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConn();
            }
            return dt;
        }

        #endregion

        #region DataTable与DataRow到实体类对象的转换
        /// <summary>
        /// DataTable到List<T>的转换
        /// </summary>
        public static List<T> DataTableToT<T>(DataTable source) where T : class, new()
        {
            List<T> itemlist = null;
            if (source == null || source.Rows.Count == 0)
            {
                return itemlist;
            }
            itemlist = new List<T>();
            T item = null;
            Type targettype = typeof(T);
            Type ptype = null;
            Object value = null;
            foreach (DataRow dr in source.Rows)
            {
                item = new T();
                foreach (PropertyInfo pi in targettype.GetProperties())
                {
                    if (pi.CanWrite && source.Columns.Contains(pi.Name))
                    {
                        if (!(pi.PropertyType.FullName == "System.Byte[]" && dr[pi.Name] == DBNull.Value))
                        {
                            ptype = Type.GetType(pi.PropertyType.FullName);
                            value = Convert.ChangeType(dr[pi.Name], ptype);
                            pi.SetValue(item, value, null);
                        }
                    }
                }
                itemlist.Add(item);
            }
            return itemlist;
        }

        /// <summary>
        /// DataRow到<T>的转换
        /// </summary>
        public static T DataRowToT<T>(DataRow source) where T : class, new()
        {
            T item = null;
            if (source == null)
            {
                return item;
            }
            item = new T();
            Type targettype = typeof(T);
            Type ptype = null;
            Object value = null;

            foreach (PropertyInfo pi in targettype.GetProperties())
            {
                if (pi.CanWrite && source.Table.Columns.Contains(pi.Name))
                {
                    if (!(pi.PropertyType.FullName == "System.Byte[]" && source[pi.Name] == DBNull.Value))
                    {
                        ptype = Type.GetType(pi.PropertyType.FullName);
                        value = Convert.ChangeType(source[pi.Name], ptype);
                        pi.SetValue(item, value, null);
                    }
                }
            }
            return item;
        }
        #endregion
    }
}
