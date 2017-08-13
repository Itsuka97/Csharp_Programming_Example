using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._1._4_1
{
    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class AuthorAttribute : System.Attribute
    {
        string name;
        int version;

        public AuthorAttribute(string name, int version)
        {
            this.name = name;
            this.version = version;
        }
    }
}
