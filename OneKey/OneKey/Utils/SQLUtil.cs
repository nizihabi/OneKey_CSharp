using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace DataUtil
{
    public class SQLUtil
    {
        private static string datasource = "Data\\Data.db";
        public static string DataSource
        {
            get { return datasource; }
            set { datasource = value; }
        }

        /// <summary>
        /// 判断数据库文件是否存在，不存在则创建
        /// </summary>
        public static void CheckDataBaseExist()
        {
            if (!File.Exists(datasource))
            {
                DirectoryInfo info = (new FileInfo(datasource)).Directory;
                if(!info.Exists)
                    info.Create();
                SQLiteConnection.CreateFile(datasource);
            }
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <returns></returns>
        private static string getConnectStr()
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = datasource;
            return builder.ToString();
        }

        /// <summary>
        /// 执行非查询语句
        /// </summary>
        /// <param name="sqlStr">SQL语句</param>
        public static void ExecuteNoQuerySQL(string sqlStr)
        {
            SQLiteConnection connection = new SQLiteConnection(getConnectStr());
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlStr, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// 执行多条非查询语句，这些语句是在一个事务中完成
        /// </summary>
        /// <param name="sqlStrs">多条语句</param>
        /// <returns>是否执行成功</returns>
        public static bool ExecuteNoQuerySQL(List<string> sqlStrs)
        {
            bool result = true;
            SQLiteConnection connection = new SQLiteConnection(getConnectStr());
            connection.Open();
            SQLiteTransaction trans = connection.BeginTransaction();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.Transaction = trans;
            try
            {
                foreach (string sql in sqlStrs)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = false;
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return result;
        }

        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sqlStr">查询语句</param>
        /// <returns>返回数据表</returns>
        public static DataTable ExecuteQuerySQL(string sqlStr)
        {
            DataSet set = new DataSet();
            SQLiteConnection connection = new SQLiteConnection(getConnectStr());
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlStr, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(set);
            connection.Close();
            if (set.Tables.Count != 0)
                return set.Tables[0];
            return null;
        }
        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="sqlStr">SQL语句</param>
        /// <returns>是否存在</returns>
        public static bool IsExist(string sqlStr)
        {
            SQLiteConnection connection = new SQLiteConnection(getConnectStr());
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlStr, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            bool result = reader.HasRows;
            connection.Close();
            return result;
        }
    }
}
