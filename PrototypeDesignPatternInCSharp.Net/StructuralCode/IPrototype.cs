using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net.StructuralCode
{
    public interface IPrototype
    {
        IPrototype Clone();
        string GetDetails();
    }
}
