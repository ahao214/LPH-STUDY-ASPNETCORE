using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.RegularExpressions;

namespace Video.Service.Domain.Users.Aggregates
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class VideoUsers : FullAggregateRoot<long, long>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        private string username;
        /// <summary>
        /// 密码
        /// </summary>
        private string password;
        /// <summary>
        /// 邮箱
        /// </summary>
        private string email;
        /// <summary>
        /// 头像
        /// </summary>
        private string avatar;
        /// <summary>
        /// 用户描述
        /// </summary>
        private string description;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; private set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 用户描述
        /// </summary>
        public string Description { get; set; }

        protected VideoUsers() { }

        public VideoUsers(string username, string password, string email, string avatar, string description)
        {
            SetUserName(username);
            UpdatePassword(password);
            UpdateEmail(email);
            Avatar = avatar;
            Description = description;
        }
        /// <summary>
        /// 修改用户名
        /// </summary>
        /// <param name="username"></param>
        /// <exception cref="UserFriendlyException"></exception>
        public void SetUserName(string username)
        {
            // 判断用户名是否符合要求
            if (username.IsNullOrWhiteSpace())
            {
                throw new UserFriendlyException("用户名不能为空");
            }
            if (username.Length < 5)
            {
                throw new UserFriendlyException("用户名长度不能小于5位");
            }

            UserName = username;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <exception cref="UserFriendlyException"></exception>
        public void UpdatePassword(string password)
        {
            if (password.IsNullOrWhiteSpace())
            {
                throw new UserFriendlyException("密码不能为空");
            }
            if (!IsComplexPwd(password))
            {
                throw new UserFriendlyException("密码过于简单");
            }
            Password = password;
        }

        /// <summary>
        /// 修改邮箱
        /// </summary>
        /// <param name="email"></param>
        /// <exception cref="UserFriendlyException"></exception>
        public void UpdateEmail(string email)
        {
            if (email.IsNullOrWhiteSpace())
            {
                throw new UserFriendlyException("邮箱不能为空");
            }
            if (!IsValidEmail(email))
            {
                throw new UserFriendlyException("邮箱校验失败");
            }
            Email = email;
        }

        public static bool IsComplexPwd(string pwd)
        {
            bool hasUpperCase = pwd.Any(char.IsUpper);
            bool hasLowerCase = pwd.Any(char.IsLower);
            bool hasDigit = pwd.Any(char.IsDigit);
            bool hasSpecialChar = pwd.Any(ch => !char.IsLetterOrDigit(ch));
            return pwd.Length >= 8 && hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = "";
            Match match = Regex.Match(email, pattern);
            return match.Success;
        }

    }

}
