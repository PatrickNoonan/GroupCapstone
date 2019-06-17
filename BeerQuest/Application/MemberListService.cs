using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class MemberListService : IMemberListService
    {
        private IMemberListRepository _memberListRepository;

        public MemberListService(IMemberListRepository memberListRepository)
        {
            _memberListRepository = memberListRepository;
        }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
