using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    interface IMemberListRepository
    {
        List<Member> GetAll();

        void Add();

        void Edit();
    }
}
