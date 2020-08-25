﻿using XiangJiang.ProjectTemplate.Abstractions.Models;
using XiangJiang.ProjectTemplate.Abstractions.Result;

namespace XiangJiang.ProjectTemplate.Abstractions.WebApi
{
    /// <summary>
    ///     WebApi 授权接口
    /// </summary>
    public interface IApiAuthorize
    {
        /// <summary>
        ///     检查请求签名合法性
        /// </summary>
        /// <param name="signature">加密签名字符串</param>
        /// <param name="timestamp">时间戳</param>
        /// <param name="nonce">随机数</param>
        /// <param name="appConfig">应用接入配置信息</param>
        /// <returns>CheckResult</returns>
        CheckResult CheckRequestSignature(string signature, string timestamp, string nonce, AppConfig appConfig);


        /// <summary>
        ///     创建合法用户获取访问令牌接口数据
        /// </summary>
        /// <param name="identityUser">IdentityUser</param>
        /// <param name="appConfig">AppConfig</param>
        /// <returns>IdentityToken</returns>
        ApiResult<IdentityToken> CreateIdentityToken(IdentityUser identityUser, AppConfig appConfig);
    }
}