using System;
using XiangJiang.ProjectTemplate.Abstractions.Result;

namespace XiangJiang.ProjectTemplate.Abstractions.Core
{
    public abstract class ApiServiceBase
    {
        protected readonly object SyncObject = new object();
        protected volatile bool HasDoneAuthoried;

        protected ApiServiceBase(string apiKey, string secretKey)
            : this("", apiKey, secretKey, false)
        {
        }

        protected ApiServiceBase(string appId, string apiKey, string secretKey, bool debug)
        {
            AppId = appId;
            ApiKey = apiKey;
            SecretKey = secretKey;
            ExpireAt = DateTime.Now;
            Debug = debug;
        }

        protected string Token { get; set; }

        protected DateTime ExpireAt { get; set; }

        protected string AppId { get; set; }

        protected string ApiKey { get; set; }

        protected string SecretKey { get; set; }

        protected bool Debug { get; set; }

        protected abstract void DoAuthorization();

        protected virtual bool NeedAuth()
        {
            if (!HasDoneAuthoried) return true;
            return false;
        }


        protected void PreAction()
        {
            DoAuthorization();
        }

        protected T DoAction<T>(ApiResult<T> apiResult) where T : class, new()
        {
            if (!apiResult.IsSuccessful) throw new AipException(apiResult.StatusCode, apiResult.Message);

            return apiResult.Data;
        }
    }
}