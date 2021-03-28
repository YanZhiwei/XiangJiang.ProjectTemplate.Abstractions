using System;
using System.Net;

namespace XiangJiang.ProjectTemplate.Abstractions.Result
{
    /// <summary>
    ///     WebApi 结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public sealed class ApiResult<T> : BasicResult<T>
    {
        #region Properties

        /// <summary>
        ///     操作结果
        /// </summary>
        public bool IsSuccessful { get; set; }

        /// <summary>
        ///     StatusCode
        /// </summary>
        public int StatusCode { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="data">返回数据</param>
        /// <param name="isSuccessful">操作结果</param>
        /// <param name="statusCode">StatusCode</param>
        public ApiResult(string message, T data, bool isSuccessful, int statusCode)
            : base(message, data)
        {
            IsSuccessful = isSuccessful;
            StatusCode = statusCode;
        }

        /// <summary>
        ///     默认无参构造函数
        /// </summary>
        public ApiResult()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        ///     失败结果
        /// </summary>
        /// <param name="message">失败内容</param>
        /// <param name="statusCode">StatusCode</param>
        /// <returns>OperatedResult</returns>
        public static ApiResult<T> Fail(string message, int statusCode = 500)
        {
            var failResult = new ApiResult<T>(message, default, false, statusCode);
            return failResult;
        }

        /// <summary>
        ///     成功结果
        /// </summary>
        /// <param name="message">成功消息</param>
        /// <param name="data">成功时候需要返回的数据对象</param>
        /// <returns>OperatedResult</returns>
        public static ApiResult<T> Success(string message, T data)
        {
            var successResult = new ApiResult<T>(message, data, true, (int) HttpStatusCode.OK);
            return successResult;
        }

        /// <summary>
        ///     成功结果
        /// </summary>
        /// <param name="data">成功时候需要返回的数据对象</param>
        /// <returns>OperatedResult</returns>
        public static ApiResult<T> Success(T data)
        {
            var successResult = new ApiResult<T>(null, data, true, (int) HttpStatusCode.OK);
            return successResult;
        }

        #endregion Methods
    }
}