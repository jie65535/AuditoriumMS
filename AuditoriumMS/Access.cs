using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace AuditoriumMS
{
    /// <summary>
    /// 数据库连接类
    /// </summary>
    public class Access
    {
        // 这里改成解决方案目录下那个accdb文件  ↓
        static string DbPath = @"F:\C#\培优礼堂票务管理系统\AuditoriumMS" + @"\DbTicketing.accdb";
        OleDbConnection oleDb = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", DbPath));
        // 私有构造函数，单例实现
        private Access()
        {
            oleDb.Open();
        }
        
        private static Access access;
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public static Access obj
        {
            get
            {
                if (access == null)
                    access = new Access();
                return access;
            }
        }

        /// <summary>
        /// 得到DataTable  适用于查询语句 返回查询结果
        /// </summary>
        public DataTable GetDataTable(string SQL)
        {
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(SQL, oleDb);
            DataTable dt = new DataTable();
            dbDataAdapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 执行命令 适用于增删改 返回受影响行数
        /// </summary>
        public int Execute(string SQL)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(SQL, oleDb);
            return oleDbCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// 字符串过滤，防止sql注入。
        /// </summary>
        /// <param name="str">参数</param>
        /// <returns>是否有敏感字符</returns>
        public static bool IsHasSQLInject(string str)
        {
            bool isHasSQLInject = false;

            //字符串中的关键字更具需要添加
            string inj_str = "'|and|exec|union|create|insert|select|delete|update|count|*|%|chr|mid|master|truncate|char|declare|xp_|or|--|+";
            str = str.ToLower().Trim();
            string[] inj_str_array = inj_str.Split('|');
            foreach (string sql in inj_str_array)
            {
                if (str.IndexOf(sql) > -1)
                {
                    isHasSQLInject = true;
                    break;
                }
            }
            return isHasSQLInject;
        }
    }
}
