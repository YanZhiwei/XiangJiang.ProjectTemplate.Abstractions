using System;

namespace XiangJiang.ProjectTemplate.Abstractions.Core
{
    [Serializable]
    public class AipException : Exception
    {
        public AipException()
        {
            Code = -1;
        }

        public AipException(string message)
            : base(message)
        {
        }

        public AipException(int code, string message)
            : base(message)
        {
            Code = code;
        }

        public int Code { get; set; }
    }
}