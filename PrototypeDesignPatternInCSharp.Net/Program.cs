using PrototypeDesignPatternInCSharp.Net.StructuralCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeConcreteFirstObject firstObject = new PrototypeConcreteFirstObject();
            firstObject.ObjectName = "First Object";
            firstObject.ID = 99;

            PrototypeConcreteFirstObject copyOfFirstObject = (PrototypeConcreteFirstObject)firstObject.Clone();
            copyOfFirstObject.ObjectName = "Copy First Object";

            Console.WriteLine(firstObject.GetDetails());
            Console.WriteLine(copyOfFirstObject.GetDetails());

            Console.ReadKey();
        }
    }
}
