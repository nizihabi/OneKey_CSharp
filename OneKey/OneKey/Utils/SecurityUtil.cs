using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace DataUtil
{
    public class SecurityUtil
    {
        /// <summary>
        /// 获取字符串的MD5值
        /// </summary>
        /// <param name="src">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string GetMD5Value(string src)
        {
            if (src == null)
            {
                return null;
            }
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(src));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <param name="encryptKey">密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string EncryptByDES(string str, string encryptKey)  
        {    
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider(); 
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);  
            byte[] data = Encoding.Unicode.GetBytes(str);
            MemoryStream MStream = new MemoryStream();     
            //使用内存流实例化加密流对象   
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);     
            CStream.Write(data, 0, data.Length);
            CStream.FlushFinalBlock();
            return Convert.ToBase64String(MStream.ToArray());
        } 
 
        /// <summary>  
        /// DES解密字符串   
        /// </summary>  
        /// <param name="str">要解密的字符串</param> 
        /// /// <param name="encryptKey">密钥</param>
        /// <returns>解密后的字符串</returns> 
        public static string DecryptByDES(string str, string encryptKey)  
        {    
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider(); 
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);   
            byte[] data = Convert.FromBase64String(str);  
            MemoryStream MStream = new MemoryStream();  
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);   
            CStream.Write(data, 0, data.Length);  
            CStream.FlushFinalBlock();      
            return Encoding.Unicode.GetString(MStream.ToArray()); 
        }

        /// <summary>
        /// 加密字符串
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <param name="encryptKey">密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string AESEncryptByAES(string str, string encryptKey)
        {
            AesCryptoServiceProvider descsp = new AesCryptoServiceProvider();
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);
            byte[] data = Encoding.Unicode.GetBytes(str);
            MemoryStream MStream = new MemoryStream();
            //使用内存流实例化加密流对象   
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);
            CStream.FlushFinalBlock();
            return Convert.ToBase64String(MStream.ToArray());
        }

        /// <summary>  
        /// 解密字符串   
        /// </summary>  
        /// <param name="str">要解密的字符串</param> 
        /// /// <param name="encryptKey">密钥</param>
        /// <returns>解密后的字符串</returns> 
        public static string AESDecryptByAES(string str, string encryptKey)
        {
            AesCryptoServiceProvider descsp = new AesCryptoServiceProvider();
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);
            byte[] data = Convert.FromBase64String(str);
            MemoryStream MStream = new MemoryStream();
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);
            CStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(MStream.ToArray());
        }  
    }
}
