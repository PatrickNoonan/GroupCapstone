using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerQuest
{
    public static class APIKey
    {
        private static string secretKey = "yourapikey";
        public static string SecretKey { get { return secretKey; } }
    }
}
