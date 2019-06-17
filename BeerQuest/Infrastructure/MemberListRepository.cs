using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class MemberListRepository : IMemberListRepository
    {
        private List<Member> _members;
        public MemberListRepository()
        {
            _members = new List<Member>();
        }
        public void Add(Member member)
        {
            _members.Add(new Member() { });
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAll()
        {
            return _members;
        }
    }
}
