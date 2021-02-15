using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionExample
{
    public class Example
    {
        public static List<Type> GetClassNames()
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            List<Type> types = new List<Type>();

            foreach (var t in executing.GetTypes())
            {
                types.Add(t);
            }

            return types;
        }

        public static List<MethodInfo> GetMethods(List<Type> types)
        {
            List<MethodInfo> methodsNew = new();

            foreach (var type in types)
            {
                MethodInfo[] methods = type.GetMethods();

                if (type.Name is "Computer" or "User")
                {
                    foreach (var method in methods)
                    {
                        if (method.DeclaringType == type)
                        {
                            methodsNew.Add(method);
                        }
                    }
                }  
            }

            return methodsNew;
        }

        public static void GetParamsName(List<MethodInfo> methods)
        {
            foreach (var m in methods)
            {
                ParameterInfo[] parameters = m.GetParameters();

                foreach (var p in parameters)
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
