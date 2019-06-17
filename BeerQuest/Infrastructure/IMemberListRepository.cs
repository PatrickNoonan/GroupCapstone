using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IMemberListRepository
    {
        List<Member> GetAll();

        void Add(Member member);
    }
}
