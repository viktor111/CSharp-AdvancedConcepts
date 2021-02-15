using ReflectionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdvancedConcepts.Examples
{
    public class RefelectionExampleCLI
    {
        internal static void Examples()
        {
            Example.GetMethodNames(Example.GetClassNames());
        }
    }
}
