namespace Video.Service.Domain.Users.Aggregates
{
    /// <summary>
    /// 用户粉丝
    /// </summary>
    public class UserFollows : Entity<long>
    {
        /// <summary>
        /// 关注者ID
        /// </summary>
        public long FollowerId { get; set; }
        /// <summary>
        /// 被关注者ID
        /// </summary>
        public long FollowedId { get; set; }
    }



}
