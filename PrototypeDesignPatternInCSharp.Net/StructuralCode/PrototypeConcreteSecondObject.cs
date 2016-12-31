using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net.StructuralCode
{
    class PrototypeConcreteSecondObject : IPrototype
    {
        public IPrototype Clone()
        {
            throw new NotImplementedException();
        }

        public string GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}
