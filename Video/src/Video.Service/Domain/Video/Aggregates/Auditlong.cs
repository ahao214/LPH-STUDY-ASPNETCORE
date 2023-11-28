using Microsoft.AspNetCore.Server.HttpSys;

namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 审计模型
    /// </summary>
    public class Auditlong : FullAggregateRoot<long, long>
    {
        #region

        /// <summary>
        /// 请求路由
        /// </summary>
        public string requestRoute;
        /// <summary>
        /// 请求Query参数
        /// </summary>
        public string requestQuery;
        /// <summary>
        /// 请求UserId
        /// </summary>
        public long userId;
        /// <summary>
        /// 请求方式
        /// </summary>
        public string requestMethod;
        /// <summary>
        /// 请求客户端标识
        /// </summary>
        public string clientIdentifier;
        /// <summary>
        /// 响应状态
        /// </summary>
        public int responseStatus;
        /// <summary>
        /// 请求IP
        /// </summary>
        public string requestIp;
        /// <summary>
        /// 扩展参数
        /// </summary>
        public Dictionary<string, string> extendedParameters;
        /// <summary>
        /// 请求耗时(ms)
        /// </summary>
        public int requestDuration;
        /// <summary>
        /// 应用环境
        /// </summary>
        public string applicationEnvironment;

        #endregion


        /// <summary>
        /// 请求路由
        /// </summary>
        public string RequestRoute { get => requestRoute; set => requestRoute = value; }
        /// <summary>
        /// 请求Query参数
        /// </summary>
        public string RequestQuery { get => requestQuery; set => requestQuery = value; }
        /// <summary>
        /// 请求UserId
        /// </summary>
        public long UserId { get => userId; set => userId = value; }
        /// <summary>
        /// 请求方式
        /// </summary>
        public string RequestMethod { get => requestMethod; set => requestMethod = value; }
        /// <summary>
        /// 请求客户端标识
        /// </summary>
        public string ClientIdentifier { get => clientIdentifier; set => clientIdentifier = value; }
        /// <summary>
        /// 响应状态
        /// </summary>
        public int ResponseStatus { get => responseStatus; set => responseStatus = value; }
        /// <summary>
        /// 请求IP
        /// </summary>
        public string RequestIp { get => requestIp; set => requestIp = value; }
        /// <summary>
        /// 扩展参数
        /// </summary>
        public Dictionary<string, string> ExtendedParameters { get => extendedParameters; set => extendedParameters = value; }
        /// <summary>
        /// 请求耗时(ms)
        /// </summary>
        public int RequestDuration { get => requestDuration; set => requestDuration = value; }
        /// <summary>
        /// 应用环境
        /// </summary>
        public string ApplicationEnvironment { get => applicationEnvironment; set => applicationEnvironment = value; }

        protected Auditlong()
        {

        }

        public Auditlong(string requestRoute, string requestQuery, long userId, string requestMethod, string clientIdentifier, int responseStatus, string requestIp, Dictionary<string, string> extendedParameters, int requestDuration, string applicationEnvironment)
        {
            RequestRoute = requestRoute;
            RequestQuery = requestQuery;
            UserId = userId;
            RequestMethod = requestMethod;
            ClientIdentifier = clientIdentifier;
            ResponseStatus = responseStatus;
            RequestIp = requestIp;
            ExtendedParameters = extendedParameters;
            RequestDuration = requestDuration;
            ApplicationEnvironment = applicationEnvironment;
        }
    }
}
