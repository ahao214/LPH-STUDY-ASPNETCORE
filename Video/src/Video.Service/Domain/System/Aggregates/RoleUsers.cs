namespace Video.Service.Domain.System.Aggregates
{
    public class RoleUsers : Entity<long>
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public long RoleId { get; set; }
    }
}
