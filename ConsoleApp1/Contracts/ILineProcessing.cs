using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Contracts
{
    internal interface ILineProcessing
    {
        void SearchSubstring(string @string, string substring);
      
    }
}