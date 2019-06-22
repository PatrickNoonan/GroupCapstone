using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ViewModel
    {
        public Member Members { get; set; }
        public IEnumerable<Rank> Ranks { get; set; }
    }
}
