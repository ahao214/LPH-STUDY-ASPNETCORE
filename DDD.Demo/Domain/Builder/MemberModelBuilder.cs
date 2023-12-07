using DDD.Demo.Domain.Model;
using DDD.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Builder
{
    /// <summary>
    /// 会员转换
    /// </summary>
    public class MemberModelBuilder
    {
        /// <summary>
        /// 从Member转换为MemberModel
        /// </summary>
        /// <param name="old"></param>
        /// <returns></returns>
        public MemberModel ToMemberModel(Member old)
        {
            MemberModel result = new MemberModel();
            if (result == null)
                return result;
            result.Id = old.Id;
            result.Name = old.Name;
            result.Password = old.Password;
            result.InsertDate = old.InsertDate;
            return result;
        }

        /// <summary>
        /// 从MemberModel转换为Member
        /// </summary>
        /// <param name="old"></param>
        /// <returns></returns>
        public Member FromMemberModel(MemberModel old)
        {
            Member result = new Member();
            if (old == null)
                return result;
            result.Id = old.Id;
            result.Name = old.Name;
            result.Password = old.Password;
            result.InsertDate = old.InsertDate;
            return result;
        }


        public List<MemberModel> ToMemberModelList(List<Member> list)
        {
            var result = new List<MemberModel>();
            if (list == null)
                return result;
            foreach (var item in list)
            {
                result.Add(ToMemberModel(item));
            }
            return result;
        }


    }
}
