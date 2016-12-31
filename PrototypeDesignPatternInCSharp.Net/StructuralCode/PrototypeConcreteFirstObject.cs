using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net.StructuralCode
{
    class PrototypeConcreteFirstObject : IPrototype
    {
        public String ObjectName { get; set; }
        public DateTime CreatedOn { get { return DateTime.Now; } }
        public int ID { get; set; }
        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }



        public string GetDetails()
        {
            return String.Format("First Object Name {0} Created on {1} ID {2}", ObjectName, CreatedOn, ID);
        }
    }
}
