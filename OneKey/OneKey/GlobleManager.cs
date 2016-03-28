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
using System.Data;

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
                                PwdID int identity(1,1) primary key,
                                UserID nvarchar(50) not null, 
                                Pwds nvarchar(50) not null,
                                Description nvarchar(200) null,
                                Type int not null
                                );";
            SQLUtil.ExecuteNoQuerySQL(createTable);

            createTable = @"create table if not exists tb_PwdType(
                                TypeID int identity(1,1) primary key,
                                TypeDes nvarchar(200) not null, 
                                UserID nvarchar(50) not null
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
            string cmd = "insert into tb_User(UserID,Password) values ('" + id + "','" + MD5Pwd + "')";
            SQLUtil.ExecuteNoQuerySQL(cmd);

        }

        /// <summary>
        /// 用户保存一条新的密码记录
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public static bool AddPwd(string pwd , string description, string TypeDes)
        {
            int typeID = getTypeID(User.GetInstance().ID, TypeDes);
            if (typeID == -1)
                return false;

            string ecrPwd = SecurityUtil.AESEncryptByAES(pwd, User.GetInstance().Password);
            string cmd = "insert into tb_PwdInfo(UserID,Pwds,Description,Type) values ('" + User.GetInstance().ID
                + "','" + ecrPwd + "','" + description + "','" + typeID + "')";
            SQLUtil.ExecuteNoQuerySQL(cmd);
            return true;
        }

        /// <summary>
        /// 增加新的类型
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <param name="typeDes">类型描述</param>
        /// <returns></returns>
        public static void AddType(string typeDes)
        {
            string cmd = "insert into tb_PwdType(TypeDes,UserID) values ('" + typeDes + "','" + User.GetInstance().ID + "')";

            SQLUtil.ExecuteNoQuerySQL(cmd);
        }

        /// <summary>
        /// 加载用户定义的类型表
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadTypeData()
        {
            string cmd = "select TypeID,TypeDes from tb_PwdType where UserID='" + User.GetInstance().ID + "'";
            DataTable dt = SQLUtil.ExecuteQuerySQL(cmd);

            return dt;
        }

        /// <summary>
        /// 检查类型是否存在
        /// </summary>
        /// <param name="typeDes">类型描述</param>
        /// <returns>返回相应的TypeID,-1代表该类型不存在</returns>
        private static int getTypeID(string userID, string typeDes)
        {
            string cmd = "select TypeID,TypeDes,UserID from tb_PwdType where TypeDes='" + typeDes + "' and UserID='" + userID + "'";
            DataTable dt = SQLUtil.ExecuteQuerySQL(cmd);
            if (dt == null)
                return -1;
            return Int32.Parse(dt.Rows[0]["TypeID"].ToString());
        }
    }
}
