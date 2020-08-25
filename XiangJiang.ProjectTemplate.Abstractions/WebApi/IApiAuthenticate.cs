using XiangJiang.ProjectTemplate.Abstractions.Models;
using XiangJiang.ProjectTemplate.Abstractions.Result;

namespace XiangJiang.ProjectTemplate.Abstractions.WebApi
{
    /// <summary>
    ///     webApi 验证系统基本接口
    /// </summary>
    public interface IApiAuthenticate
    {
        #region Methods

        /// <summary>
        ///     验证Token令牌是否合法
        /// </summary>
        /// <param name="token">令牌</param>
        /// <param name="appConfig">AppConfig</param>
        /// <returns>CheckResult</returns>
        ApiResult<string> CheckIdentityToken(string token, AppConfig appConfig);

        #endregion Methods
    }
}