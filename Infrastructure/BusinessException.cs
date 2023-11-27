namespace Infrastructure
{
    /// <summary>
    /// 业务异常类
    /// </summary>
    public class BusinessException : Exception
    {
        public int Code { get; }
        public BusinessException(string? message, int code = 400) : base(message)
        {
            Code = code;
        }

        



    }
}
