using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DBHelper{
    /// <summary>
    /// 数据访问帮助类
    /// </summary>
    public class DBHelper
    {
        //1、数据库连接字符串
        public static string connectionString;

        /// <summary>
        /// 2、根据sql查询表返回datatable（查询）
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDataTableBySql(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
            DataTable dt=new DataTable();
            try
            {
                sda.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 3、执行sql（删除添加编辑）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool ExcuteSql(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            try
            {
                com.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

		
        /// <summary>
        /// 4、查询sql单行单列值（聚合函数或者单个值）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int GetSingleBySql(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
			int result =0;
            try
            {
                result = (int)com.ExecuteScalar();
                return result;
            }
            catch
            {
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
