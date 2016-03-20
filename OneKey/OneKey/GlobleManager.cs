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

namespace OneKey
{
    class GlobleManager
    {
        /// <summary>
        /// 检查id是否存在的函数
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true——ID存在，false——ID不存在</returns>
        public static bool CheckIDExist(string id)
        {
            return false;
        }

        /// <summary>
        /// 检查登陆是否成功的函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool CheckLogin(string id, string pwd)
        {
            return false;
        }
    }
}
