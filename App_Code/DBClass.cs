using System;
using System.Collections.Generic;
using System.Web;

// 新增引用命名空间
using System.Data; // 对数据库的基本操作类
using System.Data.SqlClient;// 针对sql的
using System.Configuration; // 针对web.config的操作

namespace BookkeepingBook.App_Code
{
    public class DBClass
    {

        // 数据库连接
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                String connectionString = ConfigurationManager.ConnectionStrings["keepbookConnectionString"].ConnectionString;

                if (connection == null || connection.State == ConnectionState.Closed)
                {

                    connection = new SqlConnection(connectionString);

                    connection.Open();
                }

                return connection;
            }

        }


        public static DataTable GetDataSet(String sql)
        {
            SqlCommand command = new SqlCommand(sql, Connection);

            DataSet data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            return data.Tables[0];
        }
        public static DataTable GetDataSet(String sql, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand(sql, Connection);

            foreach (SqlParameter param in sqlParameters)
            {
                command.Parameters.Add(param);
            }

            DataSet data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            return data.Tables[0];
        }



        public static int ExcuteSql(String sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, Connection);
            return sqlCommand.ExecuteNonQuery();
        }

        public static int ExcuteSql(String sql, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand(sql, Connection);

            foreach (SqlParameter param in sqlParameters)
            {
                command.Parameters.Add(param);
            }

            return command.ExecuteNonQuery();
        }
    }
}