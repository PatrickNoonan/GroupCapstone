using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Data;

namespace Application
{
    class MemberListService : IMemberListService
    {
        private readonly ApplicationDbContext _context;


        public MemberListService()
        {
            
        }
        public void Add(Member member)
        {
            _context.Add(member);
        }

        public List<Member> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
