using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BookManage.DAL
{
    
    class SqlHelper
    {
        private static string _strConnection = @"Data Source=RAOJUN-PC\SQLEXPRESS;
                                        Initial Catalog=BookLibrary;User ID=BookAdmin;Password=123";
        private static SqlConnection conn = new SqlConnection(_strConnection);//SQL Server数据库连接对象
        DataTable datatable;
        SqlDataAdapter dataadapter;
        private static void OpenConn()//打开数据库连接
        {
            conn.Open();
        }
        private static void CloseConn()//关闭数据库连接
        {
            conn.Close();
        }
        //执行非查询的sql语句,返回受影响的行数
        public static int ExecuteNonQuery(string sql)
        {
            
        }
        //执行非查询的sql语句(带参数),返回受影响的行数
        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {

        }
        //执行查询语句，返回查询结果中的首行首列
        public static object ExecuteScalar(string sql)
        {

        }
        //执行查询语句（带参数），返回查询结果中的首行首列
        public static object ExecuteScalar(string sql,SqlParameter[] parameters,string TableName)
        {
            
        }
        //执行查询语句（带参数），返回查询结果记录集（DataTable对象）
        public  DataTable GetDataTable(string sql, SqlParameter[] parameters, string TableName)
        {
            sql = "select * from Book ";
            return datatable;
        }
        //执行查询语句，返回查询结果记录集（SqlDataReader对象-只读）
        public static SqlDataReader GetDataReader(string sql)
        {

        }
        //执行非查询的存储过程，返回受影响的行数, parameters指定存储过程的函数实参
        public static int ExecuteStoredProc(string storedProcName, SqlParameter[] parameters)
        {

        }
        ///执行查询的存储过程，返回查询结果记录集
        public static DataTable ExecuteStoredProc(string storedPrecName, SqlParameter[] parameters, string TableName)
        {

        }

        ///有2个常用的通用转换方法，采用泛型和反射技术分别实现DataTable和DataRow到实体类对象的转换；
        ///算法要求：表记录（DataTable或DataRow）包含了实体类T的所有属性，并且表字段名与T的属性名相同。
        #region DataTable与DataRow到实体类对象的转换
        ///<summary>
        ///DataTable到List<T>的转换
        ///</summary>
        public static List<T> DataTableToT<T>(DataTable source) where T : class, new()
        {
            List<T> itemlist = null;
            if (source ==null || source.Rows.Count == 0)
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
                    if(pi.CanWrite&&source.Columns.Contains(pi.Name))
                    {
                        ptype=Type.GetType(pi.PropertyType.FullName);
                        value=Convert.ChangeType(dr[pi.Name],ptype);
                        pi.SetValue(item,value,null);
                    }
                }
                itemlist.Add(item);
            }
            return itemlist;
        }

        ///DataRow到<T>的转换
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
                if(pi.CanWrite &&source.Table.Columns.Contains(pi.Name))
                {
                    ptype = Type.GetType(pi.PropertyType.FullName);
                    value = Convert.ChangeType(source[pi.Name], ptype);
                    pi.SetValue(item, value, null);
                }
            }
            return item;
        }
        #endregion
    }
}
