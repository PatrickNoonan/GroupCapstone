﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    interface IMemberListService
    {
        List<Member> GetAll();

        void Add();
    }
}
