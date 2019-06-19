using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerQuest.Helper
{
    public static class APIKey
    {
        private static string secretKey = "AIzaSyArXfn07SXf-P7E6DDIiiv1l5Er1zvtwAQ";
        public static string SecretKey { get { return secretKey; } }
    }
}
