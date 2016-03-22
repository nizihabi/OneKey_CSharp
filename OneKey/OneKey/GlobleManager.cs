/**************************************************************************************
 * 
 * 用于管理全局操作的类
 * 例如：检查登陆情况，加解密密钥等
 * 
***************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataUtil;

namespace OneKey
{
    class GlobleManager
    {
        /// <summary>
        /// 初始化数据库操作，如果不存在数据库或者相应的表，则创建
        /// </summary>
        public static void InitDatabase()
        {
            SQLUtil.CheckDataBaseExist();
            string createTable = "create table if not exists tb_User(UserID nvarchar(50) not null primary key, Password nvarchar(50) not null);"; 
            SQLUtil.ExecuteNoQuerySQL(createTable);
            createTable = @"create table if not exists tb_PwdInfo(
                                Index int identity(1,1) primary key,
                                UserID nvarchar(50) not null, 
                                Pwds nvarchar(50) not null,
                                Description nvarchar(200) null
                                );";
            SQLUtil.ExecuteNoQuerySQL(createTable);
           
        }

        /// <summary>
        /// 检查id是否存在的函数
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true——ID存在，false——ID不存在</returns>
        public static bool CheckIDExist(string id)
        {
            string cmd = "select * from tb_User where UserID = '" + id + "'";
            return SQLUtil.IsExist(cmd);
        }

        /// <summary>
        /// 检查登陆是否成功的函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool CheckLogin(string id, string pwd)
        {
            string MD5Pwd = SecurityUtil.GetMD5Value(pwd);
            string cmd = "select * from tb_User where UserID = '" + id + "' and Password='" + MD5Pwd + "'";
            if (SQLUtil.IsExist(cmd))
            {
                User.GetInstance().ID = id;
                User.GetInstance().Password = pwd;

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="id">用户的ID</param>
        /// <param name="pwd">用户登陆OneKey的密码</param>
        public static void RegisterUser(string id, string pwd)
        {
            string MD5Pwd = SecurityUtil.GetMD5Value(pwd);
            string cmd = "instert into tb_User(UserID,Password) values ('" + id + "','" + MD5Pwd + "')";
            SQLUtil.ExecuteNoQuerySQL(cmd);

        }

        /// <summary>
        /// 用户保存一条新的密码记录
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="description"></param>
        public static void AddPwd(string pwd , string description)
        {
            string ecrPwd = SecurityUtil.AESEncryptByAES(pwd, User.GetInstance().Password);
            string cmd = "instert into tb_PwdInfo(UserID,Pwds,Description) values ('" + User.GetInstance().ID
                + "','" + ecrPwd + "','" + description + "')";
            SQLUtil.ExecuteNoQuerySQL(cmd);
        }

        
    }
}
