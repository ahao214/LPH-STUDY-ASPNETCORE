using DDD.Demo.Dao;
using DDD.Demo.Domain.Builder;
using DDD.Demo.Domain.Interface;
using DDD.Demo.Domain.Model;
using DDD.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Repository
{
    /// <summary>
    /// Member仓储层
    /// </summary>
    public class MemberRepository : IMemberRepository<MemberModel>
    {
        private IProvider<Member> memberProvider = new MemberProvider();
        private MemberModelBuilder memberModelBuilder = new MemberModelBuilder();

        public MemberModel Find(int Id)
        {
            Member member = memberProvider.Select(Id);
            return memberModelBuilder.ToMemberModel(member);
        }

        public MemberModel Save(MemberModel t)
        {
            if (string.IsNullOrEmpty(t.Name))
                return t;
            if (string.IsNullOrEmpty(t.Password))
                return t;
            if (t.InsertDate == null)
                return t;
            var member = memberModelBuilder.FromMemberModel(t);
            int count = memberProvider.Insert(member);
            t = memberModelBuilder.ToMemberModel (member);
            t.Success = count > 0;
            return t;
        }

        public List<MemberModel> Select()
        {
            var list = memberProvider.Select();
            return memberModelBuilder.ToMemberModelList(list);
        }
    }
}
