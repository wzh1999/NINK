using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NIKE专卖店销售系统
{
    class DBHelper
    {
        //数据库链接字符串
        public static string ConnString = "server=.;database=NIKEDB;uid=sa;pwd=123456;";

        //数据库链接对象
        private static SqlConnection Conn = null;

        //初始化数据库链接
        private static void InitConnection()
        {
            if (Conn == null)
                Conn = new SqlConnection(ConnString);
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }

        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr,Conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //查询，获取DataSet
        public static DataSet GetDataSet(string sqlStr)
        {
            InitConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr,Conn);
            dap.Fill(ds);
            Conn.Close();
            return ds;
        }

         //查询，获取DataTable
        public static DataTable GetDataTable(string sqlStr)
        {
            return GetDataSet(sqlStr).Tables[0];
        }

        //增改删
        public static bool ExecuteNonQuery(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;
        }

        //执行集合函数
        public static object ExecuteScalar(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }
    }
}
