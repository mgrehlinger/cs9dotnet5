using System;
using System.Linq;
using System.Reflection;

namespace HelloCS
{
    class Program
    {
        int z;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");
            foreach( var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodcount = 0;
                foreach(var t in a.DefinedTypes)
                {
                    methodcount += t.GetMethods().Count();
                }
                Console.WriteLine("{0:N0} types with {1:N0} method in {2}",
                arg0: a.DefinedTypes.Count(),
                arg1: methodcount,
                arg2: r.Name);
            }

        }
    }
}
