using Microsoft.EntityFrameworkCore;
using Simple.EntityFramworkCore.Core;
using Video.Domains;
using Video.Domains.Users;

namespace Video.EntityFrameworkCore.Users
{
    public class UserInfoRepository : Repository<VideoDbContext, UserInfo>, IUserInfoRepository
    {
        public UserInfoRepository(VideoDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<UserInfoRoleView?> GetUserInfoRoleAsync(string userName, string password)
        {
            var userInfo = await _dbContext.UserInfo.Where(x => x.UserName == userName && x.Password == password)
                .Select(x => new UserInfoRoleView()
                {
                    UserName = x.UserName,
                    Password = x.Password,
                    Avatar = x.Avatar,
                    CreatedTime = x.CreatedTime,
                    Enable = x.Enable,
                    Id = x.Id,
                    Name = x.Name
                }).FirstOrDefaultAsync();               
            if (userInfo == null)
                return null;
            var query = from role in _dbContext.Role
                        join userRole in _dbContext.UserRole on role.Id equals userInfo.Id
                        select role;

            userInfo.Role = await query.ToListAsync();
            return userInfo;
        }
    }
}
