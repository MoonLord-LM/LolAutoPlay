namespace My
{
    //2015/6/2
    //My命名空间的扩展
    //引入此文件，需要确保该工程引用System，System.Drawing，System.Web，System.Windows.Forms，Microsoft.VisualBasic

    /// <summary>
    /// 编码与解码函数
    /// </summary>
    public sealed class Security
    {
        /// <summary>
        /// URL编码（例如，"微软.NET"的编码结果为"%e5%be%ae%e8%bd%af.NET"）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <param name="ToUpper">是否将结果转换为大写字母形式</param>
        /// <returns>加密后的结果字符串</returns>
        public static string URL_Encode(string Source, bool ToUpper = false)
        {
            if (ToUpper)
            {
                return System.Web.HttpUtility.UrlEncode(Source, System.Text.Encoding.UTF8).ToUpper();
            }
            return System.Web.HttpUtility.UrlEncode(Source, System.Text.Encoding.UTF8);
        }
        /// <summary>
        /// URL编码（例如，"微软.NET"的编码结果为"%e5%be%ae%e8%bd%af.NET"）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <param name="ToUpper">是否将结果转换为大写字母形式</param>
        /// <returns>加密后的结果字符串</returns>
        public static string URL_Encode(string Source, System.Text.Encoding Encoding, bool ToUpper = false)
        {
            if (ToUpper)
            {
                return System.Web.HttpUtility.UrlEncode(Source, Encoding).ToUpper();
            }
            return System.Web.HttpUtility.UrlEncode(Source, Encoding);
        }
        /// <summary>
        /// URL解码（大小写形式都可以识别）
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <returns>解密后的结果字符串</returns>
        public static string URL_Decode(string Source)
        {
            return System.Web.HttpUtility.UrlDecode(Source, System.Text.Encoding.UTF8);
        }
        /// <summary>
        /// URL解码（大小写形式都可以识别）
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>解密后的结果字符串</returns>
        public static string URL_Decode(string Source, System.Text.Encoding Encoding)
        {
            return System.Web.HttpUtility.UrlDecode(Source, Encoding);
        }
        /// <summary>
        /// Base64加密算法（加密结果的字符串中包含字母A-Z，a-z，数字0-9，符号+/=）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string Base64_Encode(string Source)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Source));
        }
        /// <summary>
        /// Base64加密算法（加密结果的字符串中包含字母A-Z，a-z，数字0-9，符号+/=）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>加密后的结果字符串</returns>
        public static string Base64_Encode(string Source, System.Text.Encoding Encoding)
        {
            return System.Convert.ToBase64String(Encoding.GetBytes(Source));
        }
        /// <summary>
        /// Base64加密算法（用于URL的改进Base64编码，加密结果的字符串中包含字母A-Z，a-z，数字0-9，符号-_=）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string Base64_URL_Encode(string Source)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Source)).Replace("+", "-").Replace("/", "_");
        }
        /// <summary>
        /// Base64加密算法（用于URL的改进Base64编码，加密结果的字符串中包含字母A-Z，a-z，数字0-9，符号-_=）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>加密后的结果字符串</returns>
        public static string Base64_URL_Encode(string Source, System.Text.Encoding Encoding)
        {
            return System.Convert.ToBase64String(Encoding.GetBytes(Source)).Replace("+", "-").Replace("/", "_");
        }
        /// <summary>
        /// Base64解密算法（要解密的字符串可以包含字母A-Z，a-z，数字0-9，符号+/=）
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <returns>解密后的结果字符串</returns>
        public static string Base64_Decode(string Source)
        {
            return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Source));
        }
        /// <summary>
        /// Base64解密算法（要解密的字符串可以包含字母A-Z，a-z，数字0-9，符号+/=）
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>解密后的结果字符串</returns>
        public static string Base64_Decode(string Source, System.Text.Encoding Encoding)
        {
            return Encoding.GetString(System.Convert.FromBase64String(Source));
        }
        /// <summary>
        /// Base64解密算法（用于URL的改进Base64解码，要解密的字符串可以包含字母A-Z，a-z，数字0-9，符号-_=）
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <returns>解密后的结果字符串</returns>
        public static string Base64_URL_Decode(string Source)
        {
            return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Source.Replace("-", "+").Replace("_", "/")));
        }
        /// <summary>
        /// Base64解密算法（用于URL的改进Base64解码，要解密的字符串可以包含字母A-Z，a-z，数字0-9，符号-_=）
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>解密后的结果字符串</returns>
        public static string Base64_URL_Decode(string Source, System.Text.Encoding Encoding)
        {
            return Encoding.GetString(System.Convert.FromBase64String(Source.Replace("-", "+").Replace("_", "/")));
        }
        /// <summary>
        /// MD5加密算法（返回16位小写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string MD5_Lower16_Encode(string Source)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Source, "MD5").Substring(8, 0x10).ToLower();
        }
        /// <summary>
        /// MD5加密算法（返回16位大写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string MD5_Upper16_Encode(string Source)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Source, "MD5").Substring(8, 0x10);
        }
        /// <summary>
        /// MD5加密算法（返回32位小写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string MD5_Lower32_Encode(string Source)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Source, "MD5").ToLower();
        }
        /// <summary>
        /// MD5加密算法（返回32位大写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string MD5_Upper32_Encode(string Source)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Source, "MD5");
        }
        /// <summary>
        /// SHA1加密算法（返回40位小写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA1_Lower40_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "").ToLower();
        }
        /// <summary>
        /// SHA1加密算法（返回40位大写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA1_Upper40_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "");
        }
        /// <summary>
        /// SHA256加密算法（返回64位小写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA256_Lower64_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "").ToLower();
        }
        /// <summary>
        /// SHA256加密算法（返回64位大写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA256_Upper64_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "");
        }
        /// <summary>
        /// SHA384加密算法（返回96位小写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA384_Lower96_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA384Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "").ToLower();
        }
        /// <summary>
        /// SHA384加密算法（返回96位大写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA384_Upper96_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA384Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "");
        }
        /// <summary>
        /// SHA512加密算法（返回128位小写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA512_Lower128_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA512Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "").ToLower();
        }
        /// <summary>
        /// SHA512加密算法（返回128位大写结果）
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static string SHA512_Upper128_Encode(string Source)
        {
            return System.BitConverter.ToString(new System.Security.Cryptography.SHA512Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Source))).Replace("-", "");
        }
        /// <summary>
        /// DES加密算法
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <param name="SecretKey">加密密钥（8的整数倍字节数的字符串）</param>
        /// <returns>加密后的结果字符串</returns>
        public static byte[] DES_Encode(string Source, string SecretKey)
        {
            System.Security.Cryptography.DESCryptoServiceProvider provider = new System.Security.Cryptography.DESCryptoServiceProvider();
            try
            {
                provider.Key = System.Text.Encoding.UTF8.GetBytes(SecretKey);
            }
            catch (System.ArgumentException)
            {
                byte[] buffer = new byte[0];
                return buffer;
            }
            provider.IV = System.Text.Encoding.UTF8.GetBytes(SecretKey);
            System.IO.MemoryStream stream2 = new System.IO.MemoryStream();
            System.Security.Cryptography.CryptoStream stream = new System.Security.Cryptography.CryptoStream(stream2, provider.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
            stream.Write(System.Text.Encoding.UTF8.GetBytes(Source), 0, System.Text.Encoding.UTF8.GetBytes(Source).Length);
            stream.FlushFinalBlock();
            return stream2.ToArray();
        }
        /// <summary>
        /// DES解密算法
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <param name="SecretKey">解密密钥（8的整数倍字节数的字符串）</param>
        /// <returns>解密后的结果字符串</returns>
        public static string DES_Decode(byte[] Source, string SecretKey)
        {
            System.Security.Cryptography.DESCryptoServiceProvider provider = new System.Security.Cryptography.DESCryptoServiceProvider();
            provider.Key = System.Text.Encoding.UTF8.GetBytes(SecretKey);
            provider.IV = System.Text.Encoding.UTF8.GetBytes(SecretKey);
            System.IO.MemoryStream stream2 = new System.IO.MemoryStream();
            System.Security.Cryptography.CryptoStream stream = new System.Security.Cryptography.CryptoStream(stream2, provider.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
            stream.Write(Source, 0, Source.Length);
            try
            {
                stream.FlushFinalBlock();
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                return "";
            }
            return System.Text.Encoding.UTF8.GetString(stream2.ToArray());
        }
        /// <summary>
        /// RSA加密算法
        /// </summary>
        /// <param name="Source">要加密的字符串</param>
        /// <returns>加密后的结果字符串</returns>
        public static byte[] RSA_Encode(string Source)
        {
            System.Security.Cryptography.RSACryptoServiceProvider provider = new System.Security.Cryptography.RSACryptoServiceProvider();
            provider.FromXmlString("<RSAKeyValue><Modulus>pZGIiC3CxVYpTJ4dLylSy2TLXW+R9EyRZ39ekSosvRKf7iPuz4oPlHqjssh4Glbj/vTUIMFzHFC/9zC56GggNLfZBjh6fc3adq5cXGKlU74kAyM2z7gdYlUHtLT/GwDp4YcQKeSb9GjcvsXbUp0mrzI/axzueLIqK+R07rnv3yc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
            return provider.Encrypt(System.Text.Encoding.UTF8.GetBytes(Source), true);
        }
        /// <summary>
        /// RSA解密算法
        /// </summary>
        /// <param name="Source">要解密的字符串</param>
        /// <returns>解密后的结果字符串</returns>
        public static string RSA_Decode(byte[] Source)
        {
            string str;
            System.Security.Cryptography.RSACryptoServiceProvider provider = new System.Security.Cryptography.RSACryptoServiceProvider();
            provider.FromXmlString("<RSAKeyValue><Modulus>pZGIiC3CxVYpTJ4dLylSy2TLXW+R9EyRZ39ekSosvRKf7iPuz4oPlHqjssh4Glbj/vTUIMFzHFC/9zC56GggNLfZBjh6fc3adq5cXGKlU74kAyM2z7gdYlUHtLT/GwDp4YcQKeSb9GjcvsXbUp0mrzI/axzueLIqK+R07rnv3yc=</Modulus><Exponent>AQAB</Exponent><P>0wCnxVUMgu+Uqp3UJ18bp9Ahdad36wDMwa0tmHxZJUvBZEfcYpsxmSHLpTUBCcAIg2eJL5g/iK9LrIwDBvUZ+w==</P><Q>yOB6ZwG9TuXMRPCA9cFTKCoHEsreDZluptHEfG3HvnS1lp5xwRCHXVuh7VWOM0G2gnZ/JWwWIfcqf30UTWvTxQ==</Q><DP>BTc67nHPwVzSu/TyzZZYRKmsahAdsr1uUktJmT9ZpMZenW/5Tqavby2arxbEU81faIAir/5/c42BvV4opP9iCQ==</DP><DQ>QETR5LMBxoRvXn80Q2yfFnKb4L9XXDKC3IywuL7G8YCVuKLo8kQ/ivcOT8jXvj6ADi2rcGWsjyFtT2zNWhftoQ==</DQ><InverseQ>jwpY6fpkzwtLOABZQncXMC4h7VbYrx+sZeSrBFXAgw1WMSs9YsT6EQcDRjpGt7JAkP14nSTSIVJNd23jZURCLw==</InverseQ><D>cw6SqcfbLVV198d9EnQOFEgkRvcsn2/CMAFET27WjkHuIAiagWE4+H7NWYWUaQFvCZNMAsNMYiX/cSFMYCRUFBBgkPqaqQ3+3qCs/kKiWpDjRwX8eXrMAnWniFDEoxc229Mxl4QZrcYKVRxrCIq8wKamuoWgwN0M+3CAiLwLvNk=</D></RSAKeyValue>");
            try
            {
                str = System.Text.Encoding.UTF8.GetString(provider.Decrypt(Source, true));
            }
            catch (System.Exception)
            {
                return "";
            }
            return str;
        }
    }

    /// <summary>
    /// 网络访问函数
    /// </summary>
    public sealed class Http
    {
        /// <summary>
        /// 获取网页源码
        /// </summary>
        /// <param name="URL">网页链接</param>
        /// <returns>网页源码字符串</returns>
        public static string GetString(string URL)
        {
            System.Net.WebClient Client = new System.Net.WebClient();
            Client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                return Client.DownloadString(URL);
            }
            catch (System.Exception)
            {
                return "";
            }
        }
        /// <summary>
        /// 获取网页源码
        /// </summary>
        /// <param name="URL">网页链接</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>网页源码字符串</returns>
        public static string GetString(string URL, System.Text.Encoding Encoding)
        {
            System.Net.WebClient Client = new System.Net.WebClient();
            Client.Encoding = Encoding;
            try
            {
                return Client.DownloadString(URL);
            }
            catch (System.Exception)
            {
                return "";
            }
        }
        /// <summary>
        /// 下载文件到磁盘
        /// </summary>
        /// <param name="URL">文件链接</param>
        /// <param name="FilePath">文件保存路径（可以是相对路径）</param>
        /// <returns>是否下载成功</returns>
        public static bool DownloadFile(string URL, string FilePath)
        {
            System.Net.WebClient Client = new System.Net.WebClient();
            try
            {
                Client.DownloadFile(new System.Uri(URL), FilePath);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }

    /// <summary>
    /// 磁盘读写函数
    /// </summary>
    public sealed class IO
    {
        /// <summary>
        /// 读取文件为字符串
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        /// <returns>字符串（读取失败返回空字符串""）</returns>
        public static string ReadString(string FilePath)
        {
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(FilePath, System.Text.Encoding.UTF8);
                string str2 = reader.ReadToEnd();
                reader.Dispose();
                return str2;
            }
            catch (System.Exception)
            {
                return "";
            }
        }
        /// <summary>
        /// 将字符串写入文件（覆盖）
        /// </summary>
        /// <param name="Source">字符串</param>
        /// <param name="FilePath">文件路径</param>
        /// <returns>是否写入成功</returns>
        public static bool WriteString(string Source, string FilePath)
        {
            try
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(FilePath, false, System.Text.Encoding.UTF8);
                writer.Write(Source);
                writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串写入文件（追加）
        /// </summary>
        /// <param name="Source">字符串</param>
        /// <param name="FilePath">文件路径</param>
        /// <returns>是否写入成功</returns>
        public static bool AppendString(string Source, string FilePath)
        {
            try
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(FilePath, true, System.Text.Encoding.UTF8);
                writer.Write(Source);
                writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串数组写入文件
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否写入成功</returns>
        public static bool SaveStringArray(ref System.Collections.ArrayList StringArray, string FilePath)
        {
            System.IO.StreamWriter Writer;
            System.Text.StringBuilder Builder;
            try
            {
                Builder = new System.Text.StringBuilder();
                for (int i = 0; i < StringArray.Count - 1; i++)
                {
                    Builder.Append(StringArray[i] + "\r\n");
                }
                if (StringArray.Count > 0)
                {
                    Builder.Append(StringArray[StringArray.Count - 1]);
                }
                Writer = new System.IO.StreamWriter(FilePath, false, System.Text.Encoding.UTF8);
                Writer.Write(Builder);
                Writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串数组写入文件
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否写入成功</returns>
        public static bool SaveStringArray(ref System.Collections.ArrayList StringArray, string FilePath, System.Text.Encoding Encoding)
        {
            System.IO.StreamWriter Writer;
            System.Text.StringBuilder Builder;
            try
            {
                Builder = new System.Text.StringBuilder();
                for (int i = 0; i < StringArray.Count - 1; i++)
                {
                    Builder.Append(StringArray[i] + "\r\n");
                }
                if (StringArray.Count > 0)
                {
                    Builder.Append(StringArray[StringArray.Count - 1]);
                }
                Writer = new System.IO.StreamWriter(FilePath, false, Encoding);
                Writer.Write(Builder);
                Writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串数组写入文件
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否写入成功</returns>
        public static bool SaveStringArray(ref System.Collections.Generic.List<string> StringArray, string FilePath)
        {
            System.IO.StreamWriter Writer;
            System.Text.StringBuilder Builder;
            try
            {
                Builder = new System.Text.StringBuilder();
                for (int i = 0; i < StringArray.Count - 1; i++)
                {
                    Builder.Append(StringArray[i] + "\r\n");
                }
                if (StringArray.Count > 0)
                {
                    Builder.Append(StringArray[StringArray.Count - 1]);
                }
                Writer = new System.IO.StreamWriter(FilePath, false, System.Text.Encoding.UTF8);
                Writer.Write(Builder);
                Writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串数组写入文件
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否写入成功</returns>
        public static bool SaveStringArray(ref System.Collections.Generic.List<string> StringArray, string FilePath, System.Text.Encoding Encoding)
        {
            System.IO.StreamWriter Writer;
            System.Text.StringBuilder Builder;
            try
            {
                Builder = new System.Text.StringBuilder();
                for (int i = 0; i < StringArray.Count - 1; i++)
                {
                    Builder.Append(StringArray[i] + "\r\n");
                }
                if (StringArray.Count > 0)
                {
                    Builder.Append(StringArray[StringArray.Count - 1]);
                }
                Writer = new System.IO.StreamWriter(FilePath, false, Encoding);
                Writer.Write(Builder);
                Writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串数组写入文件
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否写入成功</returns>
        public static bool SaveStringArray(ref string[] StringArray, string FilePath)
        {
            System.IO.StreamWriter Writer;
            System.Text.StringBuilder Builder;
            try
            {
                Builder = new System.Text.StringBuilder();
                for (int i = 0; i < StringArray.Length - 1; i++)
                {
                    Builder.Append(StringArray[i] + "\r\n");
                }
                if (StringArray.Length > 0)
                {
                    Builder.Append(StringArray[StringArray.Length - 1]);
                }
                Writer = new System.IO.StreamWriter(FilePath, false, System.Text.Encoding.UTF8);
                Writer.Write(Builder);
                Writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将字符串数组写入文件
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否写入成功</returns>
        public static bool SaveStringArray(ref string[] StringArray, string FilePath, System.Text.Encoding Encoding)
        {
            System.IO.StreamWriter Writer;
            System.Text.StringBuilder Builder;
            try
            {
                Builder = new System.Text.StringBuilder();
                for (int i = 0; i < StringArray.Length - 1; i++)
                {
                    Builder.Append(StringArray[i] + "\r\n");
                }
                if (StringArray.Length > 0)
                {
                    Builder.Append(StringArray[StringArray.Length - 1]);
                }
                Writer = new System.IO.StreamWriter(FilePath, false, Encoding);
                Writer.Write(Builder);
                Writer.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取文件中的字符串数组
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadStringArray(ref System.Collections.ArrayList StringArray, string FilePath)
        {
            System.IO.StreamReader Reader;
            try
            {
                Reader = new System.IO.StreamReader(FilePath, System.Text.Encoding.UTF8);
                StringArray = new System.Collections.ArrayList(Reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' }));
                Reader.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取文件中的字符串数组
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadStringArray(ref System.Collections.ArrayList StringArray, string FilePath, System.Text.Encoding Encoding)
        {
            System.IO.StreamReader Reader;
            try
            {
                Reader = new System.IO.StreamReader(FilePath, Encoding);
                StringArray = new System.Collections.ArrayList(Reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' }));
                Reader.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取文件中的字符串数组
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadStringArray(ref System.Collections.Generic.List<string> StringArray, string FilePath)
        {
            System.IO.StreamReader Reader;
            try
            {
                Reader = new System.IO.StreamReader(FilePath, System.Text.Encoding.UTF8);
                StringArray = new System.Collections.Generic.List<string>(Reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' }));
                Reader.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取文件中的字符串数组
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadStringArray(ref System.Collections.Generic.List<string> StringArray, string FilePath, System.Text.Encoding Encoding)
        {
            System.IO.StreamReader Reader;
            try
            {
                Reader = new System.IO.StreamReader(FilePath, Encoding);
                StringArray = new System.Collections.Generic.List<string>(Reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' }));
                Reader.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取文件中的字符串数组
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadStringArray(ref string[] StringArray, string FilePath)
        {
            System.IO.StreamReader Reader;
            try
            {
                Reader = new System.IO.StreamReader(FilePath, System.Text.Encoding.UTF8);
                StringArray = Reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' });
                Reader.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取文件中的字符串数组
        /// </summary>
        /// <param name="StringArray">字符串数组</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadStringArray(ref string[] StringArray, string FilePath, System.Text.Encoding Encoding)
        {
            System.IO.StreamReader Reader;
            try
            {
                Reader = new System.IO.StreamReader(FilePath, Encoding);
                StringArray = Reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' });
                Reader.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取指定目录下的全部的文件
        /// </summary>
        /// <param name="FilePathArray">保存文件路径的字符串数组</param>
        /// <param name="SearchDirectory">要搜索的文件夹路径</param>
        /// <returns>是否获取成功</returns>
        public static bool GetAllFilePath(ref System.Collections.Generic.List<string> FilePathArray, string SearchDirectory)
        {
            System.Collections.Generic.List<string> Directory = new System.Collections.Generic.List<string>();
            try
            {
                foreach (string Temp in System.IO.Directory.GetFiles(SearchDirectory))
                {
                    FilePathArray.Add(Temp);
                }
                foreach (string Temp in System.IO.Directory.GetDirectories(SearchDirectory))
                {
                    Directory.Add(Temp);
                }
                int Index = 0;
                while (Directory.Count > Index)
                {
                    SearchDirectory = Directory[Index];
                    Index++;
                    foreach (string Temp in System.IO.Directory.GetFiles(SearchDirectory))
                    {
                        FilePathArray.Add(Temp);
                    }
                    foreach (string Temp in System.IO.Directory.GetDirectories(SearchDirectory))
                    {
                        Directory.Add(Temp);
                    }
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取指定文件的行数
        /// </summary>
        /// <param name="FileLine">文件行数</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <returns>是否获取成功</returns>
        public static bool GetFileLine(ref int FileLine, string FilePath)
        {
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(FilePath, System.Text.Encoding.UTF8);
                FileLine = reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' }).Length;
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取指定文件的行数
        /// </summary>
        /// <param name="FileLine">文件行数</param>
        /// <param name="FilePath">文件路径（可以是相对路径）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否获取成功</returns>
        public static bool GetFileLine(ref int FileLine, string FilePath, System.Text.Encoding Encoding)
        {
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(FilePath, Encoding);
                FileLine = reader.ReadToEnd().Replace("\r\n", "\n").Split(new char[] { '\n' }).Length;
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将程序嵌入的资源文件写入为磁盘文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <param name="FilePath">写入到磁盘的文件路径</param>
        /// <returns>是否执行成功</returns>
        public static bool WriteResourceFile(string ResourceName, string FilePath)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                System.IO.FileStream stream2 = new System.IO.FileStream(FilePath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                stream2.Write(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                stream2.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的图片类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourcePicture">图片</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourcePicture(ref System.Drawing.Bitmap ResourcePicture, string ResourceName)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                ResourcePicture = new System.Drawing.Bitmap(executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的文本类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceString">文本</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceString(ref string ResourceString, string ResourceName)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceString = System.Text.Encoding.UTF8.GetString(buffer);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的文本类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceString">文本</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceString(ref string ResourceString, string ResourceName, System.Text.Encoding Encoding)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceString = Encoding.GetString(buffer);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的字符串数组类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceArray">字符串数组</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceArray(ref System.Collections.ArrayList ResourceArray, string ResourceName)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceArray = new System.Collections.ArrayList(System.Text.Encoding.UTF8.GetString(buffer).Replace("\r\n", "\n").Split(new char[] { '\n' }));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的字符串数组类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceArray">字符串数组</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceArray(ref System.Collections.ArrayList ResourceArray, string ResourceName, System.Text.Encoding Encoding)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceArray = new System.Collections.ArrayList(Encoding.GetString(buffer).Replace("\r\n", "\n").Split(new char[] { '\n' }));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的字符串数组类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceArray">字符串数组</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceArray(ref System.Collections.Generic.List<string> ResourceArray, string ResourceName)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceArray = new System.Collections.Generic.List<string>(System.Text.Encoding.UTF8.GetString(buffer).Replace("\r\n", "\n").Split(new char[] { '\n' }));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的字符串数组类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceArray">字符串数组</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceArray(ref System.Collections.Generic.List<string> ResourceArray, string ResourceName, System.Text.Encoding Encoding)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceArray = new System.Collections.Generic.List<string>(Encoding.GetString(buffer).Replace("\r\n", "\n").Split(new char[] { '\n' }));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的字符串数组类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceArray">字符串数组</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceArray(ref string[] ResourceArray, string ResourceName)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceArray = System.Text.Encoding.UTF8.GetString(buffer).Replace("\r\n", "\n").Split(new char[] { '\n' });
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取程序嵌入的字符串数组类型的资源文件（注意必须在解决方案资源管理器中，将资源文件的"属性"-"生成操作"设置为"嵌入的资源"）
        /// </summary>
        /// <param name="ResourceArray">字符串数组</param>
        /// <param name="ResourceName">资源文件名称（注意这个参数的值为资源文件在工程内的相对路径，例如A.jpg文件在Resources文件夹内，则此处的参数应为"Resources.A.jpg"）</param>
        /// <param name="Encoding">使用的编码格式（默认UTF-8）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadResourceArray(ref string[] ResourceArray, string ResourceName, System.Text.Encoding Encoding)
        {
            try
            {
                System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + "." + ResourceName);
                byte[] buffer = new byte[((int)(manifestResourceStream.Length - 1)) + 1];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Dispose();
                ResourceArray = Encoding.GetString(buffer).Replace("\r\n", "\n").Split(new char[] { '\n' });
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 创建快捷方式
        /// </summary>
        /// <param name="TargetPath">快捷方式指向的路径（建议使用绝对路径，使用相对路径时，默认将以桌面作为父目录）</param>
        /// <param name="LinkFilePath">快捷方式文件的路径（可以是相对路径，如"1.lnk"）</param>
        /// <param name="Arguments">打开程序的参数（例如"/?"）</param>
        /// <param name="Description">鼠标悬停在快捷方式上的描述</param>
        /// <param name="WorkingDirectory">快捷方式的起始位置（不设置此参数时，按照系统默认，自动设置为快捷方式指向的路径的父目录）</param>
        /// <returns>是否创建成功</returns>
        public static bool CreatLinkFile(string TargetPath, string LinkFilePath, string Arguments = "", string Description = "", string WorkingDirectory = "")
        {
            try
            {
                if (System.IO.File.Exists(LinkFilePath))
                {
                    System.IO.File.Delete(LinkFilePath);
                }
                if (WorkingDirectory == "")
                {
                    WorkingDirectory = System.IO.Directory.GetParent(LinkFilePath).FullName;
                }
                object instance = Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(Microsoft.VisualBasic.Interaction.CreateObject("WScript.Shell", ""), null, "CreateShortcut", new object[] { LinkFilePath }, null, null, new bool[] { true });
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(instance, null, "TargetPath", new object[] { TargetPath }, null, null);
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(instance, null, "IconLocation", new object[] { TargetPath }, null, null);
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(instance, null, "Arguments", new object[] { Arguments }, null, null);
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(instance, null, "Description", new object[] { Description }, null, null);
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(instance, null, "WorkingDirectory", new object[] { WorkingDirectory }, null, null);
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateCall(instance, null, "Save", new object[0], null, null, null, true);
                instance = null;
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 读取快捷方式指向的路径
        /// </summary>
        /// <param name="TargetPath">快捷方式指向的路径（获得完整的绝对路径）</param>
        /// <param name="LinkFilePath">快捷方式文件的路径（可以是相对路径，如"1.lnk"）</param>
        /// <returns>是否读取成功</returns>
        public static bool ReadLinkFile(ref string TargetPath, string LinkFilePath)
        {
            try
            {
                object objectValue = Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(Microsoft.VisualBasic.Interaction.CreateObject("WScript.Shell", ""), null, "CreateShortcut", new object[] { LinkFilePath }, null, null, new bool[] { true });
                TargetPath = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(objectValue, null, "TargetPath", new object[0], null, null, null));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }

    /// <summary>
    /// 字符串处理函数
    /// </summary>
    public sealed class StringData
    {
        /// <summary>
        /// 搜索字符串（从第一个开始字符串的位置，向后搜寻结束字符串，取出中间的部分）
        /// </summary>
        /// <param name="SourceCode">要搜索的字符串</param>
        /// <param name="BeginString">开始字符串</param>
        /// <param name="EndString">结束字符串</param>
        /// <returns>搜索结果字符串（无结果时返回空字符串）</returns>
        public static string SearchForward(ref string SourceCode, string BeginString, string EndString)
        {
            if (!SourceCode.Contains(BeginString))
            {
                return "";
            }
            SourceCode = SourceCode.Substring(SourceCode.IndexOf(BeginString) + BeginString.Length);
            if (!SourceCode.Contains(EndString))
            {
                return "";
            }
            return SourceCode.Substring(0, SourceCode.IndexOf(EndString));
        }
        /// <summary>
        /// 搜索字符串（从最后一个结束字符串的位置，向前搜寻开始字符串，取出中间的部分）
        /// </summary>
        /// <param name="SourceCode">要搜索的字符串</param>
        /// <param name="BeginString">开始字符串</param>
        /// <param name="EndString">结束字符串</param>
        /// <returns>搜索结果字符串（无结果时返回空字符串）</returns>
        public static string SearchBackward(ref string SourceCode, string BeginString, string EndString)
        {
            if (!SourceCode.Contains(EndString))
            {
                return "";
            }
            SourceCode = SourceCode.Substring(0, SourceCode.LastIndexOf(EndString));
            if (!SourceCode.Contains(BeginString))
            {
                return "";
            }
            return SourceCode.Substring(SourceCode.LastIndexOf(BeginString) + BeginString.Length);
        }
        /// <summary>
        /// 搜索字符串（从第一个开始字符串的位置，向后搜寻最后一个结束字符串的位置，取出中间的部分）
        /// </summary>
        /// <param name="SourceCode">要搜索的字符串</param>
        /// <param name="BeginString">开始字符串</param>
        /// <param name="EndString">结束字符串</param>
        /// <returns>搜索结果字符串（无结果时返回空字符串）</returns>
        public static string SearchMiddle(ref string SourceCode, string BeginString, string EndString)
        {
            if (!SourceCode.Contains(BeginString))
            {
                return "";
            }
            SourceCode = SourceCode.Substring(SourceCode.IndexOf(BeginString) + BeginString.Length);
            if (!SourceCode.Contains(EndString))
            {
                return "";
            }
            return SourceCode.Substring(0, SourceCode.LastIndexOf(EndString));
        }
        /// <summary>
        /// 搜索字符串（从第一个开始字符串的位置，向后搜寻结束字符串，取出中间的部分，重复向后搜索，返回数组）
        /// </summary>
        /// <param name="SourceCode">要搜索的字符串</param>
        /// <param name="BeginString">开始字符串</param>
        /// <param name="EndString">结束字符串</param>
        /// <returns>搜索结果字符串数组（无结果时返回空数组）</returns>
        public static System.Collections.Generic.List<string> SearchAllForward(ref string SourceCode, string BeginString, string EndString)
        {
            System.Collections.Generic.List<string> Temp = new System.Collections.Generic.List<string>();
            while (SourceCode.Contains(BeginString))
            {
                SourceCode = SourceCode.Substring(SourceCode.IndexOf(BeginString) + BeginString.Length);
                if (!SourceCode.Contains(EndString))
                {
                    return Temp;
                }
                Temp.Add(SourceCode.Substring(0, SourceCode.IndexOf(EndString)));
            }
            return Temp;
        }
        /// <summary>
        /// 搜索字符串（从最后一个结束字符串的位置，向前搜寻开始字符串，取出中间的部分，重复向前搜索，返回数组）
        /// </summary>
        /// <param name="SourceCode">要搜索的字符串</param>
        /// <param name="BeginString">开始字符串</param>
        /// <param name="EndString">结束字符串</param>
        /// <returns>搜索结果字符串数组（无结果时返回空数组）</returns>
        public static System.Collections.Generic.List<string> SearchAllBackward(ref string SourceCode, string BeginString, string EndString)
        {
            System.Collections.Generic.List<string> Temp = new System.Collections.Generic.List<string>();
            while (SourceCode.Contains(EndString))
            {
                SourceCode = SourceCode.Substring(0, SourceCode.LastIndexOf(EndString));
                if (!SourceCode.Contains(BeginString))
                {
                    return Temp;
                }
                Temp.Add(SourceCode.Substring(SourceCode.LastIndexOf(BeginString) + BeginString.Length));
            }
            return Temp;
        }
        /// <summary>
        /// 搜索字符串（从第一个开始字符串的位置，向后搜寻最后一个结束字符串的位置，取出中间的部分，重复向中间搜索，返回数组）
        /// </summary>
        /// <param name="SourceCode">要搜索的字符串</param>
        /// <param name="BeginString">开始字符串</param>
        /// <param name="EndString">结束字符串</param>
        /// <returns>搜索结果字符串数组（无结果时返回空数组）</returns>
        public static System.Collections.Generic.List<string> SearchAllMiddle(ref string SourceCode, string BeginString, string EndString)
        {
            System.Collections.Generic.List<string> Temp = new System.Collections.Generic.List<string>();
            while (SourceCode.Contains(BeginString))
            {
                SourceCode = SourceCode.Substring(SourceCode.IndexOf(BeginString) + BeginString.Length);
                if (!SourceCode.Contains(EndString))
                {
                    return Temp;
                }
                Temp.Add(SourceCode.Substring(0, SourceCode.LastIndexOf(EndString)));
            }
            return Temp;
        }
        /// <summary>
        /// 对两个字符串数组取交集（取出满足在第一个数组里，也在第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static System.Collections.ArrayList Intersect(ref System.Collections.ArrayList StringArray1, ref System.Collections.ArrayList StringArray2)
        {
            System.Collections.ArrayList list2 = new System.Collections.ArrayList();
            foreach (string str in StringArray1)
            {
                foreach (string str2 in StringArray2)
                {
                    if (str == str2)
                    {
                        list2.Add(str);
                        break;
                    }
                }
            }
            return list2;
        }
        /// <summary>
        /// 对两个字符串数组取交集（取出满足在第一个数组里，也在第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static System.Collections.Generic.List<string> Intersect(ref System.Collections.Generic.List<string> StringArray1, ref System.Collections.Generic.List<string> StringArray2)
        {
            System.Collections.Generic.List<string> list2 = new System.Collections.Generic.List<string>();
            foreach (string str in StringArray1)
            {
                foreach (string str2 in StringArray2)
                {
                    if (str == str2)
                    {
                        list2.Add(str);
                        break;
                    }
                }
            }
            return list2;
        }
        /// <summary>
        /// 对两个字符串数组取交集（取出满足在第一个数组里，也在第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static string[] Intersect(ref string[] StringArray1, ref string[] StringArray2)
        {
            System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
            foreach (string str in StringArray1)
            {
                foreach (string str2 in StringArray2)
                {
                    if (str == str2)
                    {
                        list.Add(str);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
        /// <summary>
        /// 对两个字符串数组取并集（取出第一个数组里的元素，然后取出第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static System.Collections.ArrayList Union(ref System.Collections.ArrayList StringArray1, ref System.Collections.ArrayList StringArray2)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            foreach (string str in StringArray1)
            {
                list.Add(str);
            }
            foreach (string str2 in StringArray2)
            {
                list.Add(str2);
            }
            return list;
        }
        /// <summary>
        /// 对两个字符串数组取并集（取出第一个数组里的元素，然后取出第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static System.Collections.Generic.List<string> Union(ref System.Collections.Generic.List<string> StringArray1, ref System.Collections.Generic.List<string> StringArray2)
        {
            System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
            foreach (string str in StringArray1)
            {
                list.Add(str);
            }
            foreach (string str2 in StringArray2)
            {
                list.Add(str2);
            }
            return list;
        }
        /// <summary>
        /// 对两个字符串数组取并集（取出第一个数组里的元素，然后取出第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static string[] Union(ref string[] StringArray1, ref string[] StringArray2)
        {
            System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
            foreach (string str in StringArray1)
            {
                list.Add(str);
            }
            foreach (string str2 in StringArray2)
            {
                list.Add(str2);
            }
            return list.ToArray();
        }
        /// <summary>
        /// 对两个字符串数组取差集（取出满足在第一个数组里，但是不在第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static System.Collections.ArrayList Except(ref System.Collections.ArrayList StringArray1, ref System.Collections.ArrayList StringArray2)
        {
            System.Collections.ArrayList list2 = new System.Collections.ArrayList();
            bool flag = false;
            foreach (string str in StringArray1)
            {
                flag = false;
                foreach (string str2 in StringArray2)
                {
                    if (str == str2)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    list2.Add(str);
                }
            }
            return list2;
        }
        /// <summary>
        /// 对两个字符串数组取差集（取出满足在第一个数组里，但是不在第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static System.Collections.Generic.List<string> Except(ref System.Collections.Generic.List<string> StringArray1, ref System.Collections.Generic.List<string> StringArray2)
        {
            System.Collections.Generic.List<string> list2 = new System.Collections.Generic.List<string>();
            bool flag = false;
            foreach (string str in StringArray1)
            {
                flag = false;
                foreach (string str2 in StringArray2)
                {
                    if (str == str2)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    list2.Add(str);
                }
            }
            return list2;
        }
        /// <summary>
        /// 对两个字符串数组取差集（取出满足在第一个数组里，但是不在第二个数组里的元素）
        /// </summary>
        /// <param name="StringArray1">字符串数组</param>
        /// <param name="StringArray2">字符串数组</param>
        /// <returns>取出的元素的集合</returns>
        public static string[] Except(ref string[] StringArray1, ref string[] StringArray2)
        {
            System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
            bool flag = false;
            foreach (string str in StringArray1)
            {
                flag = false;
                foreach (string str2 in StringArray2)
                {
                    if (str == str2)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    list.Add(str);
                }
            }
            return list.ToArray();
        }
        /// <summary>
        /// 将一个对象转换为JSON字符串（必须为常见类型的数组对象，或是含有若干属性的自定义类的对象）
        /// </summary>
        /// <param name="JsonObject">含有JSON信息的对象（会识别是否为数组、会识别自定义的类的属性、会进行基本的字符串转义以保证满足JSON格式）</param>
        /// <returns>JSON字符串</returns>
        public static string ChangeObjectToJson(ref object JsonObject)
        {
            if ((JsonObject.GetType().IsPrimitive | (JsonObject.GetType() == typeof(string))) | (JsonObject.GetType() == typeof(System.DateTime)))
            {
                return ("\"" + JsonObject.ToString().Replace("\r", @"\r").Replace("\n", @"\n").Replace("\"", "\\\"") + "\"");
            }
            if ((JsonObject.GetType().IsGenericType | JsonObject.GetType().IsArray) | (JsonObject.GetType() == typeof(System.Collections.ArrayList)))
            {
                System.Collections.IEnumerator enumerator;
                System.Text.StringBuilder builder = new System.Text.StringBuilder("[");
                enumerator = ((System.Collections.IEnumerable)JsonObject).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    object objectValue = enumerator.Current;
                    builder.Append(ChangeObjectToJson(ref objectValue) + ",");
                }
                if (builder.Length > 1)
                {
                    builder.Remove(builder.Length - 1, 1);
                }
                builder.Append("]");
                return builder.ToString();
            }
            System.Text.StringBuilder builder2 = new System.Text.StringBuilder("{");
            foreach (System.Reflection.PropertyInfo info in JsonObject.GetType().GetProperties())
            {
                builder2.Append("\"" + info.Name + "\":");
                object obj3 = info.GetValue(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(JsonObject), null);
                if (obj3 == null)
                {
                    builder2.Append("null,");
                }
                else
                {
                    System.Type type = obj3.GetType();
                    if ((type.IsPrimitive | (type == typeof(string))) | (type == typeof(System.DateTime)))
                    {
                        builder2.Append("\"" + info.GetValue(JsonObject, null).ToString().Replace("\r", @"\r").Replace("\n", @"\n").Replace("\"", "\\\"") + "\",");
                    }
                    else
                    {
                        object obj4 = info.GetValue(JsonObject, null);
                        builder2.Append(ChangeObjectToJson(ref obj4) + ",");
                    }
                }
            }
            if (builder2.Length > 1)
            {
                builder2.Remove(builder2.Length - 1, 1);
            }
            builder2.Append("}");
            return builder2.ToString();
        }

    }

    /// <summary>
    /// HTML代码处理函数
    /// </summary>
    public sealed class HTML
    {
        /// <summary>
        /// 获取网页源码中指定标签的元素的文本
        /// </summary>
        /// <param name="Source">网页源代码</param>
        /// <param name="HtmlTag">元素标签</param>
        /// <returns>文本字符串数组</returns>
        public static System.Collections.Generic.List<string> GetTextByTagName(string Source, string HtmlTag)
        {
            System.Collections.Generic.List<string> Temp = new System.Collections.Generic.List<string>();
            System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();
            browser.DocumentText = "";
            browser.Document.OpenNew(true).Write(Source);
            System.Windows.Forms.HtmlElementCollection elementsByTagName = browser.Document.GetElementsByTagName(HtmlTag);
            for (int i = 0; i <= elementsByTagName.Count - 1; i++)
            {
                Temp.Add(elementsByTagName[i].InnerText);
            }
            return Temp;
        }
        /// <summary>
        /// 获取网页源码中指定ID的元素的文本
        /// </summary>
        /// <param name="Source">网页源代码</param>
        /// <param name="Id">元素ID</param>
        /// <returns>文本字符串</returns>
        public static string GetTextById(string Source, string Id)
        {
            System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();
            browser.DocumentText = "";
            browser.Document.OpenNew(true).Write(Source);
            return browser.Document.GetElementById(Id).InnerText;
        }
    }

    /// <summary>
    /// 访问主机及其资源、服务和数据
    /// </summary>
    public sealed class Computer
    {
        /// <summary>
        /// 延时关闭计算机（注意会取代之前可能存在的关机计划）
        /// </summary>
        /// <param name="DelaySecond">延时时间（单位秒，最多可以延时10年）</param>
        /// <returns>是否执行成功</returns>
        public static bool ShutDown(int DelaySecond = 0)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardInput.WriteLine("shutdown -a >nul 2>nul");
                process.StandardInput.WriteLine("shutdown -s -t " + DelaySecond + " >nul 2>nul");
                process.StandardInput.WriteLine("exit");
                process.StandardOutput.ReadToEnd();
                process.StandardOutput.Close();
                process.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 延时重启计算机（注意会取代之前可能存在的关机计划）
        /// </summary>
        /// <param name="DelaySecond">延时时间（单位秒，最多可以延时10年）</param>
        /// <returns>是否执行成功</returns>
        public static bool ShutDownReboot(int DelaySecond = 0)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardInput.WriteLine("shutdown -a >nul 2>nul");
                process.StandardInput.WriteLine("shutdown -r -t " + DelaySecond + " >nul 2>nul");
                process.StandardInput.WriteLine("exit");
                process.StandardOutput.ReadToEnd();
                process.StandardOutput.Close();
                process.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 取消关机计划（没有关机计划时则无效果）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool ShutDownAbort()
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardInput.WriteLine("shutdown -a >nul 2>nul");
                process.StandardInput.WriteLine("exit");
                process.StandardOutput.ReadToEnd();
                process.StandardOutput.Close();
                process.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 打开指定的程序（多次调用本函数会打开程序的多个实例，新打开的程序会夺取鼠标焦点）
        /// </summary>
        /// <param name="TaskName">程序名称（例如"notepad"或"notepad.exe"）</param>
        /// <returns>是否执行成功</returns>
        public static bool TaskRun(string TaskName)
        {
            try
            {
                if (!TaskName.ToLower().EndsWith(".exe"))
                {
                    TaskName = TaskName + ".exe";
                }
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardInput.WriteLine((string)TaskName);
                process.StandardOutput.ReadLine();
                process.StandardOutput.Close();
                process.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 打开指定的程序（多次调用本函数会打开程序的多个实例，新打开的程序不会夺取鼠标焦点）
        /// </summary>
        /// <param name="TaskName">程序名称（例如"notepad"或"notepad.exe"）</param>
        /// <returns>是否执行成功</returns>
        public static bool ShellRun(string TaskName)
        {
            try
            {
                if (!TaskName.ToLower().EndsWith(".exe"))
                {
                    TaskName = TaskName + ".exe";
                }
                Microsoft.VisualBasic.Interaction.Shell(TaskName, Microsoft.VisualBasic.AppWinStyle.NormalNoFocus, false, -1);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 打开指定的命令行程序（多次调用本函数会打开程序的多个实例，新打开的程序不会夺取鼠标焦点）
        /// </summary>
        /// <param name="TaskName">完整的命令行语句（例如，应当使用"notepad.exe"而不是"notepad"）</param>
        /// <returns>是否执行成功</returns>
        public static bool Shell(string TaskName)
        {
            try
            {
                Microsoft.VisualBasic.Interaction.Shell(TaskName, Microsoft.VisualBasic.AppWinStyle.NormalNoFocus, false, -1);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 通过进程的名称，获取进程的文件的完整路径（注意，该程序必须在运行中）
        /// </summary>
        /// <param name="ProcessName">程序名称（例如"notepad"或"notepad.exe"）</param>
        /// <returns>成功返回完整的文件路径，失败返回进程名称（例如"notepad.exe"）</returns>
        public static string GetProcessFilePath(string ProcessName)
        {
            if (ProcessName.ToLower().EndsWith(".exe"))
            {
                ProcessName = ProcessName.Substring(0, ProcessName.Length-4);
            }
            System.Diagnostics.Process[] A = System.Diagnostics.Process.GetProcessesByName(ProcessName);
            if (A.Length > 0)
            {
                return A[0].MainModule.FileName;
            }
            else
            {
                return ProcessName;
            }
        }
        /// <summary>
        /// 关闭指定的程序（程序如果有多个实例，会一并结束，多次调用本函数无特别效果）
        /// </summary>
        /// <param name="TaskName">程序名称（例如"notepad"或"notepad.exe"）</param>
        /// <returns>是否执行成功</returns>
        public static bool TaskKill(string TaskName)
        {
            try
            {
                if (!TaskName.ToLower().EndsWith(".exe"))
                {
                    TaskName = TaskName + ".exe";
                }
                TaskName = "\"" + TaskName + "\"";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardOutput.ReadLine();
                process.StandardInput.WriteLine("taskkill /f /t /im " + TaskName);
                process.StandardInput.WriteLine("exit");
                process.StandardOutput.ReadToEnd();
                process.StandardOutput.Close();
                process.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 关闭指定的程序（程序如果有多个实例，会一并结束，多次调用本函数无特别效果）
        /// </summary>
        /// <param name="TaskName">程序名称（例如"notepad"或"notepad.exe"）</param>
        /// <returns>是否执行成功</returns>
        public static bool ShellKill(string TaskName)
        {
            try
            {
                if (!TaskName.ToLower().EndsWith(".exe"))
                {
                    TaskName = TaskName + ".exe";
                }
                TaskName = "\"" + TaskName + "\"";
                Microsoft.VisualBasic.Interaction.Shell("taskkill /f /t /im " + TaskName, Microsoft.VisualBasic.AppWinStyle.Hide, false, -1);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（System.Drawing.Bitmap类型）
        /// </summary>
        /// <returns>成功返回屏幕截图的Bitmap，失败返回新建的0*0像素的Bitmap</returns>
        public static System.Drawing.Bitmap SaveScreen()
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                return image;
            }
            catch (System.Exception)
            {
                return new System.Drawing.Bitmap(0, 0);
            }
        }
        /// <summary>
        /// 获取指定区域的屏幕截图（System.Drawing.Bitmap类型）
        /// </summary>
        /// <param name="Position">指定区域</param>
        /// <returns>成功返回指定区域的屏幕截图的Bitmap，失败返回新建的Position.Width*Position.Height像素的Bitmap</returns>
        public static System.Drawing.Bitmap SaveScreen(System.Drawing.Rectangle Position)
        {
            try
            {
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(Position.Width, Position.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(Position.Left, Position.Top, 0, 0, Position.Size);
                }
                return image;
            }
            catch (System.Exception)
            {
                return new System.Drawing.Bitmap(Position.Width, Position.Height);
            }
        }
        /// <summary>
        /// 获取屏幕截图（默认保存格式，实测1920*1080分辨率的截图文件大小为293K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreen(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（bmp格式，实测1920*1080分辨率的截图文件大小为7.91M，文件大小最大）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenBmp(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Bmp);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（png格式，实测1920*1080分辨率的截图文件大小为293K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenPng(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Png);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（jpeg格式，实测1920*1080分辨率的截图文件大小为212K，文件大小最小）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenJpeg(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（gif格式，实测1920*1080分辨率的截图文件大小为232K，文件大小较小）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenGif(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Gif);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（ico格式，实测1920*1080分辨率的截图文件大小为294K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenIcon(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Icon);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（tiff格式，实测1920*1080分辨率的截图文件大小为388K，文件大小较大）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenTiff(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Tiff);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（exif格式，实测1920*1080分辨率的截图文件大小为294K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenExif(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Exif);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（memorybmp格式，实测1920*1080分辨率的截图文件大小为294K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenMemoryBmp(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.MemoryBmp);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（emf格式，实测1920*1080分辨率的截图文件大小为293K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenEmf(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Emf);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕截图（wmf格式，实测1920*1080分辨率的截图文件大小为293K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenWmf(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                image.Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Wmf);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕缩略图（默认保存格式，实测1920*1080【长宽都只保留50%】分辨率，缩略图文件大小为157K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenThumbnail(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                System.IntPtr callbackData = new System.IntPtr(0);
                image.GetThumbnailImage(bounds.Width / 2, bounds.Height / 2, null, callbackData).Save(ScreenFilePath);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕缩略图（png格式，实测1920*1080【长宽都只保留50%】分辨率，缩略图文件大小为157K，文件大小中等）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenPngThumbnail(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                System.IntPtr callbackData = new System.IntPtr(0);
                image.GetThumbnailImage(bounds.Width / 2, bounds.Height / 2, null, callbackData).Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Png);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取屏幕缩略图（jpeg格式，实测1920*1080【长宽都只保留50%】分辨率，缩略图文件大小为64K，文件大小最小）
        /// </summary>
        /// <param name="ScreenFilePath">截图文件保存路径</param>
        /// <returns>是否执行成功</returns>
        public static bool SaveScreenJpegThumbnail(string ScreenFilePath)
        {
            try
            {
                System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
                }
                System.IntPtr callbackData = new System.IntPtr(0);
                image.GetThumbnailImage(bounds.Width / 2, bounds.Height / 2, null, callbackData).Save(ScreenFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 发送按键（使用Microsoft.VisualBasic.Devices.Computer类的Keyboard.SendKeys方式）
        /// </summary>
        /// <param name="Keys">按键字符串（参照SendKeys的规则）</param>
        /// <returns>是否执行成功</returns>
        public static bool SendKeys(string Keys)
        {
            try
            {
                (new Microsoft.VisualBasic.Devices.Computer()).Keyboard.SendKeys(Keys);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 发送按键（使用Wscript.Shell的SendKeys方式）
        /// </summary>
        /// <param name="Keys">按键字符串（参照SendKeys的规则）</param>
        /// <returns>是否执行成功</returns>
        public static bool SendKeysWshShell(string Keys)
        {
            try
            {
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateCall(Microsoft.VisualBasic.Interaction.CreateObject("Wscript.Shell", ""), null, "SendKeys", new object[] { Keys }, null, null, new bool[] { true }, true);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 发送按键（使用System.Windows.Forms.SendKeys.Send方式）
        /// </summary>
        /// <param name="Keys">按键字符串（参照SendKeys的规则）</param>
        /// <returns>是否执行成功</returns>
        public static bool SendKeysWinForm(string Keys)
        {
            try
            {
                System.Windows.Forms.SendKeys.Send(Keys);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "keybd_event", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "MapVirtualKeyA", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern long MapVirtualKey(long wCode, long wMapType);
        /// <summary>
        /// 按下单个按键（并保持按下状态直到下次按同一个键，连续调用本函数，可执行组合键）
        /// </summary>
        /// <param name="Key">键位</param>
        /// <returns>是否执行成功</returns>
        public static bool PressKey(System.Windows.Forms.Keys Key)
        {
            try
            {
                keybd_event((byte)Key, (byte)MapVirtualKey((byte)Key, 0), 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 按下单个按键（并保持按下状态直到下次按同一个键，连续调用本函数，可执行组合键）
        /// </summary>
        /// <param name="KeyChar">键位</param>
        /// <returns>是否执行成功</returns>
        public static bool PressKey(char KeyChar)
        {
            try
            {
                keybd_event((byte)Microsoft.VisualBasic.Strings.Asc(KeyChar), (byte)MapVirtualKey((byte)Microsoft.VisualBasic.Strings.Asc(KeyChar), 0), 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 按下多个按键（并保持按下状态直到下次按同一个键，连续调用本函数，可执行组合键）
        /// </summary>
        /// <param name="KeyString">键位（只允许字母和数字）</param>
        /// <returns>是否执行成功</returns>
        public static bool PressKey(string KeyString)
        {
            try
            {
                foreach (char ch in KeyString.ToCharArray())
                {
                    keybd_event((byte)Microsoft.VisualBasic.Strings.Asc(ch), (byte)MapVirtualKey((byte)Microsoft.VisualBasic.Strings.Asc(ch), 0), 0, 0);
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 释放单个按键（取消按下状态）
        /// </summary>
        /// <param name="Key">键位</param>
        /// <returns>是否执行成功</returns>
        public static bool ReleaseKey(System.Windows.Forms.Keys Key)
        {
            try
            {
                keybd_event((byte)Key, (byte)MapVirtualKey((byte)Key, 0), 2, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 释放单个按键（取消按下状态）
        /// </summary>
        /// <param name="KeyChar">键位</param>
        /// <returns>是否执行成功</returns>
        public static bool ReleaseKey(char KeyChar)
        {
            try
            {
                keybd_event((byte)Microsoft.VisualBasic.Strings.Asc(KeyChar), (byte)MapVirtualKey((byte)Microsoft.VisualBasic.Strings.Asc(KeyChar), 0), 2, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 释放多个按键（取消按下状态）
        /// </summary>
        /// <param name="KeyString">键位（只允许字母和数字）</param>
        /// <returns>是否执行成功</returns>
        public static bool ReleaseKey(string KeyString)
        {
            try
            {
                foreach (char ch in KeyString.ToCharArray())
                {
                    keybd_event((byte)Microsoft.VisualBasic.Strings.Asc(ch), (byte)MapVirtualKey((byte)Microsoft.VisualBasic.Strings.Asc(ch), 0), 2, 0);
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "mouse_event", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool mouse_event(MouseEvent dwFlags, int dX, int dY, int dwData, int dwExtraInfo);
        private enum MouseEvent
        {
            AbsoluteLocation = 0x8000,
            AbsoluteScale = 0xffff,
            LeftButtonDown = 2,
            LeftButtonUp = 4,
            MiddleButtonDown = 0x20,
            MiddleButtonUp = 0x40,
            Move = 1,
            RightButtonDown = 8,
            RightButtonUp = 0x10,
            Wheel = 0x800
        }
        /// <summary>
        /// 将鼠标位置移动一段距离（移动距离单位为像素）
        /// </summary>
        /// <param name="x">横向距离</param>
        /// <param name="y">纵向距离</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseMoveByPixel(int x = 0, int y = 0)
        {
            try
            {
                mouse_event(MouseEvent.Move, x, y, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将鼠标位置移动一段距离（移动距离单位为屏幕百分比）
        /// </summary>
        /// <param name="x">横向距离</param>
        /// <param name="y">纵向距离</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseMoveByPercent(double x = 0.0, double y = 0.0)
        {
            try
            {
                mouse_event(MouseEvent.Move, (int)(x * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), (int)(y * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 移动鼠标到指定位置（定位单位为像素）
        /// </summary>
        /// <param name="x">横坐标</param>
        /// <param name="y">纵坐标</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseMoveToPixel(int x = 0, int y = 0)
        {
            try
            {
                mouse_event(MouseEvent.AbsoluteLocation | MouseEvent.Move, (int)((double)x / (double)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 65535), (int)((double)y / (double)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 65535), 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 移动鼠标到指定位置（定位单位为屏幕百分比）
        /// </summary>
        /// <param name="x">横坐标</param>
        /// <param name="y">纵坐标</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseMoveToPercent(double x = 0.0, double y = 0.0)
        {
            try
            {
                mouse_event(MouseEvent.AbsoluteLocation | MouseEvent.Move, (int)(x * 65535), (int)(y * 65535), 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 按下鼠标左键（保持按下状态）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseLeftDown()
        {
            try
            {
                mouse_event(MouseEvent.LeftButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 释放鼠标左键（取消按下状态）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseLeftUp()
        {
            try
            {
                mouse_event(MouseEvent.LeftButtonUp, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标左键单击
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseLeftClick()
        {
            try
            {
                mouse_event(MouseEvent.LeftButtonUp | MouseEvent.LeftButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标左键双击
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseLeftDoubleClick()
        {
            try
            {
                mouse_event(MouseEvent.LeftButtonUp | MouseEvent.LeftButtonDown, 0, 0, 0, 0);
                mouse_event(MouseEvent.LeftButtonUp | MouseEvent.LeftButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 按下鼠标中键（保持按下状态）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseMiddleDown()
        {
            try
            {
                mouse_event(MouseEvent.MiddleButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 释放鼠标中键（取消按下状态）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseMiddleUp()
        {
            try
            {
                mouse_event(MouseEvent.MiddleButtonUp, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标中键单击
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseMiddleClick()
        {
            try
            {
                mouse_event(MouseEvent.MiddleButtonUp | MouseEvent.MiddleButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标中键双击
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseMiddleDoubleClick()
        {
            try
            {
                mouse_event(MouseEvent.MiddleButtonUp | MouseEvent.MiddleButtonDown, 0, 0, 0, 0);
                mouse_event(MouseEvent.MiddleButtonUp | MouseEvent.MiddleButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 按下鼠标右键（保持按下状态）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseRightDown()
        {
            try
            {
                mouse_event(MouseEvent.RightButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 释放鼠标右键（取消按下状态）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseRightUp()
        {
            try
            {
                mouse_event(MouseEvent.RightButtonUp, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标右键单击
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseRightClick()
        {
            try
            {
                mouse_event(MouseEvent.RightButtonUp | MouseEvent.RightButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标右键双击
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool MouseRightDoubleClick()
        {
            try
            {
                mouse_event(MouseEvent.RightButtonUp | MouseEvent.RightButtonDown, 0, 0, 0, 0);
                mouse_event(MouseEvent.RightButtonUp | MouseEvent.RightButtonDown, 0, 0, 0, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标滚轮向上滚动（滚动距离单位为像素）
        /// </summary>
        /// <param name="ScrollValue">滚动距离</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseWheelUp(int ScrollValue)
        {
            try
            {
                mouse_event(MouseEvent.Wheel, 0, 0, ScrollValue, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 鼠标滚轮向下滚动（滚动距离单位为像素）
        /// </summary>
        /// <param name="ScrollValue">滚动距离</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseWheelDown(int ScrollValue)
        {
            try
            {
                mouse_event(MouseEvent.Wheel, 0, 0, 0 - ScrollValue, 0);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetAsyncKeyState", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern short GetAsyncKeyState(int vKey);
        /// <summary>
        /// 判断物理键盘设备上的单个键位是否正处于被按下的状态（侦测键盘的硬件中断）
        /// </summary>
        /// <param name="Key">键位</param>
        /// <returns>是否按下</returns>
        public static bool KeyBeingPressed(System.Windows.Forms.Keys Key)
        {
            short asyncKeyState = GetAsyncKeyState((int)Key);
            return ((asyncKeyState == -32768) | (asyncKeyState == -32767));
        }
        /// <summary>
        /// 判断物理键盘设备上的单个键位是否正处于被按下的状态（侦测键盘的硬件中断）
        /// </summary>
        /// <param name="KeyChar">键位</param>
        /// <returns>是否按下</returns>
        public static bool KeyBeingPressed(char KeyChar)
        {
            short asyncKeyState = GetAsyncKeyState((int)Microsoft.VisualBasic.Strings.Asc(KeyChar));
            return ((asyncKeyState == -32768) | (asyncKeyState == -32767));
        }
        /// <summary>
        /// 判断物理键盘设备上的多个键位是否都处于被按下的状态（侦测键盘的硬件中断）
        /// </summary>
        /// <param name="KeyString">键位（只允许字母和数字）</param>
        /// <returns>是否按下</returns>
        public static bool KeyBeingPressed(string KeyString)
        {
            foreach (char ch in KeyString.ToCharArray())
            {
                short asyncKeyState = GetAsyncKeyState((int)Microsoft.VisualBasic.Strings.Asc(ch));
                if ((asyncKeyState != -32768) & (asyncKeyState != -32767))
                {
                    return false;
                }
            }
            return true;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindowA", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern System.IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowRect", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern System.IntPtr GetWindowRect(System.IntPtr hwnd, ref RECT lpRect);
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        /// <summary>
        /// 根据窗口标题获取窗口的大小和位置（当多个标题相同的窗体存在时，默认获取上一个活动的窗体）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>窗口的大小和位置（System.Drawing.Rectangle）</returns>
        public static System.Drawing.Rectangle FindWindow(string WindowTitle)
        {
            RECT rect = new RECT();
            string lpClassName = null;
            GetWindowRect(FindWindow(lpClassName, WindowTitle), ref rect);
            return new System.Drawing.Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern System.IntPtr GetForegroundWindow();
        /// <summary>
        /// 获取当前的焦点窗口的大小和位置
        /// </summary>
        /// <returns>窗口的大小和位置（System.Drawing.Rectangle）</returns>
        public static System.Drawing.Rectangle FindFocusWindow()
        {
            RECT rect = new RECT();
            GetWindowRect(GetForegroundWindow(), ref rect);
            return new System.Drawing.Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessageA", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(System.IntPtr hwnd, int wMsg, int wParam, System.Text.StringBuilder lParam);
        /// <summary>
        /// 获取当前的焦点窗口的窗口标题文字
        /// </summary>
        /// <returns>窗口标题文字（失败则返回空字符串""）</returns>
        public static string FindFocusWindowTitle()
        {
            System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder(4048);
            int WM_GETTEXT = 13;
            SendMessage(GetForegroundWindow(), WM_GETTEXT, 4048, StringBuilder);
            return StringBuilder.ToString();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SetForegroundWindow(System.IntPtr hwnd);
        /// <summary>
        /// 根据窗口标题获取窗口，并将其设置为当前的焦点窗口（实测：窗体处于最小化状态时，不会弹出到最前，只会在任务栏出现白色闪烁效果；窗体处于普通状态时，不一定会弹出到最前，可能只在任务栏出现黄色闪烁效果）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>设置成功返回非0值，失败返回0</returns>
        public static int SetForegroundWindow(string WindowTitle)
        {
            string lpClassName = null;
            return SetForegroundWindow(FindWindow(lpClassName, WindowTitle));
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessageA", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// 根据窗口标题获取窗口，并允许窗口重绘
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>设置成功返回非0值，失败返回0</returns>
        public static int SetWindowCanRedraw(string WindowTitle)
        {
            string lpClassName = null;
            int WM_SETREDRAW = 11;
            return SendMessage(FindWindow(lpClassName, WindowTitle), WM_SETREDRAW, 1, 0);
        }
        /// <summary>
        /// 根据窗口标题获取窗口，并禁止窗口重绘
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>设置成功返回非0值，失败返回0</returns>
        public static int SetWindowCanNotRedraw(string WindowTitle)
        {
            string lpClassName = null;
            int WM_SETREDRAW = 11;
            return SendMessage(FindWindow(lpClassName, WindowTitle), WM_SETREDRAW, 0, 0);
        }        
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "ShowWindow", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool ShowWindow(System.IntPtr hWnd, uint nCmdShow);
        /// <summary>
        /// 根据窗口标题获取窗口，并将其设置为普通样式（取消最大化、最小化效果。实测：如果窗体当前为不可重绘的状态，则会恢复为可重绘的状态，但是函数会返回false。）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>是否设置成功</returns>
        public static bool ShowWindowNormal(string WindowTitle)
        {
            uint SW_SHOWNORMAL = 1;
            string lpClassName = null;
            return ShowWindow(FindWindow(lpClassName, WindowTitle), SW_SHOWNORMAL);
        }
        /// <summary>
        /// 根据窗口标题获取窗口，并将其设置为最小化样式
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>是否设置成功</returns>
        public static bool ShowWindowMinimize(string WindowTitle)
        {
            uint SW_SHOWMINIMIZED = 2;
            string lpClassName = null;
            return ShowWindow(FindWindow(lpClassName, WindowTitle), SW_SHOWMINIMIZED);
        }
        /// <summary>
        /// 根据窗口标题获取窗口，并将其设置为最大化样式
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <returns>是否设置成功</returns>
        public static bool ShowWindowMaximize(string WindowTitle)
        {
            uint SW_SHOWMAXIMIZED = 3;
            string lpClassName = null;
            return ShowWindow(FindWindow(lpClassName, WindowTitle), SW_SHOWMAXIMIZED);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "MoveWindow", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool MoveWindow(System.IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        /// <summary>
        /// 根据窗口标题修改窗口的位置和大小（当多个标题相同的窗体存在时，默认修改上一个活动的窗体；注意可能会把窗口移动到用户鼠标无法触及的位置）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <param name="Left">屏幕左边距</param>
        /// <param name="Top">屏幕上边距</param>
        /// <param name="Width">宽度 </param>
        /// <param name="Height">高度</param>
        /// <returns>是否修改成功</returns>
        public static bool MoveWindow(string WindowTitle, int Left, int Top, int Width, int Height)
        {
            RECT rect = new RECT();
            string lpClassName = null;
            System.IntPtr hwnd = FindWindow(lpClassName, WindowTitle);
            if (hwnd == System.IntPtr.Zero)
            {
                return false;
            }
            return MoveWindow(hwnd, Left, Top, Width, Height, true);
        }
        /// <summary>
        /// 根据窗口标题修改窗口的位置和大小（当多个标题相同的窗体存在时，默认修改上一个活动的窗体；注意可能会把窗口移动到用户鼠标无法触及的位置）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <param name="Position">指定区域</param>
        /// <returns>是否修改成功</returns>
        public static bool MoveWindow(string WindowTitle, System.Drawing.Rectangle Position)
        {
            RECT rect = new RECT();
            string lpClassName = null;
            System.IntPtr hwnd = FindWindow(lpClassName, WindowTitle);
            if (hwnd == System.IntPtr.Zero)
            {
                return false;
            }
            return MoveWindow(hwnd, Position.Left, Position.Top, Position.Width, Position.Height, true);
        }
        /// <summary>
        /// 根据窗口标题拖动窗口（当多个标题相同的窗体存在时，默认修改上一个活动的窗体；注意可能会把窗口移动到用户鼠标无法触及的位置）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <param name="MoveX">向右拖动的距离（为负值则向左拖动）</param>
        /// <param name="MoveY">向下拖动的距离（为负值则向上拖动）</param>
        /// <returns>是否拖动成功</returns>
        public static bool DragWindow(string WindowTitle, int MoveX = 0, int MoveY = 0)
        {
            RECT rect = new RECT();
            string lpClassName = null;
            System.IntPtr hwnd = FindWindow(lpClassName, WindowTitle);
            GetWindowRect(hwnd, ref rect);
            if (hwnd == System.IntPtr.Zero)
            {
                return false;
            }
            return MoveWindow(hwnd, rect.Left + MoveX, rect.Top + MoveY, rect.Right - rect.Left, rect.Bottom - rect.Top, true);
        }
        /// <summary>
        /// 根据窗口标题修改窗口的大小（当多个标题相同的窗体存在时，默认修改上一个活动的窗体；注意某些程序的窗口大小，实际上不能被修改的太小）
        /// </summary>
        /// <param name="WindowTitle">窗口标题（字符串不能有任何差别）</param>
        /// <param name="Width">宽度</param>
        /// <param name="Height">高度</param>
        /// <returns>是否修改成功</returns>
        public static bool ResizeWindow(string WindowTitle, int Width, int Height)
        {
            RECT rect = new RECT();
            string lpClassName = null;
            System.IntPtr hwnd = FindWindow(lpClassName, WindowTitle);
            GetWindowRect(hwnd, ref rect);
            if (hwnd == System.IntPtr.Zero)
            {
                return false;
            }
            return MoveWindow(hwnd, rect.Left, rect.Top, Width, Height, true);
        }
        /// <summary>
        /// 将鼠标位置移动一段距离（移动距离单位为像素，使用System.Windows.Forms.Cursor）
        /// </summary>
        /// <param name="x">横向距离</param>
        /// <param name="y">纵向距离</param>
        /// <returns>是否执行成功</returns>
        public static bool MouseMove(int x, int y)
        {
            try
            {
                System.Drawing.Point position = System.Windows.Forms.Cursor.Position;
                position.Offset(x, y);
                System.Windows.Forms.Cursor.Position = position;
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取鼠标的当前位置（System.Windows.Forms.Cursor.Position）
        /// </summary>
        /// <returns>位置坐标（System.Drawing.Point）</returns>
        public static System.Drawing.Point MousePosition()
        {
            return System.Windows.Forms.Cursor.Position;
        }
        /// <summary>
        /// 获取鼠标的当前位置的屏幕颜色
        /// </summary>
        /// <returns>颜色值（System.Drawing.Color）</returns>
        public static System.Drawing.Color MousePositionColor()
        {
            System.Drawing.Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(bounds.Width, bounds.Height);
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(image))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size);
            }
            return image.GetPixel(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
        }
        /// <summary>
        /// 强制把所有运行的程序窗口最小化，显示桌面（效果类似Win7系统鼠标点击屏幕右下角）
        /// </summary>
        /// <returns>是否执行成功</returns>
        public static bool ShowDesktop()
        {
            try
            {
                Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateCall(Microsoft.VisualBasic.Interaction.CreateObject("Shell.Application", ""), null, "ToggleDesktop", new object[0], null, null, null, true);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 获取上一个Win32 API调用产生的错误代码（实测：出现错误后，错误信息会一直保留，直到被下一个错误信息替换）
        /// </summary>
        /// <returns>错误代码（默认为0）</returns>
        public static int Win32ErrorCode()
        {
            return System.Runtime.InteropServices.Marshal.GetLastWin32Error();
        }
        /// <summary>
        /// 获取上一个Win32 API调用产生的错误说明（实测：出现错误后，错误信息会一直保留，直到被下一个错误信息替换）
        /// </summary>
        /// <returns>错误说明（默认为"操作成功完成。"）</returns>
        public static string Win32ErrorMessage()
        {
            return new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error()).Message;
        }
    }
}
