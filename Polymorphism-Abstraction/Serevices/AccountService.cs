using Polymorphism_Abstraction.Serevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Serevices
{
    internal class AccountService : IAccountService, ICommonService
    {
        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}
