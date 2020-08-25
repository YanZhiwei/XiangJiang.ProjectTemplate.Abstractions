namespace XiangJiang.ProjectTemplate.Abstractions.Result
{
    /// <summary>
    ///     返回结果基类
    /// </summary>
    public abstract class BasicResult<T> 
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="data">返回数据</param>
        protected BasicResult(string message, T data)
        {
            Message = message?.Trim();
            Data = data;
        }

        /// <summary>
        ///     默认无参构造函数
        /// </summary>
        protected BasicResult()
        {
        }

        /// <summary>
        ///     获取 消息内容
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     获取 返回数据
        /// </summary>
        public T Data { get; set; }
    }
}

