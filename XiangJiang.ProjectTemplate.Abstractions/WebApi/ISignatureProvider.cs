using System;

namespace XiangJiang.ProjectTemplate.Abstractions.WebApi
{
    public interface ISignatureProvider
    {
        /// <summary>
        ///     生成签名字符串
        /// </summary>
        /// <param name="appSecret">签名密钥</param>
        /// <param name="timestamp">时间戳</param>
        /// <param name="nonce">随机数</param>
        /// <returns>WebApi签名</returns>
        string Create(Guid appSecret, string timestamp, string nonce);
    }
}