using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDependancyInjection.DPI
{
    public class DependancyContainer
    {
        List<Dependancy> _dependancies;

        public DependancyContainer()
        {
            _dependancies = new();
        }
        
        public void AddSingleton<T>()
        {
            _dependancies.Add(new Dependancy(typeof(T), DependancyLifetimes.Singleton));
        }

        public void AddTransient<T>()
        {
            _dependancies.Add(new Dependancy(typeof(T), DependancyLifetimes.Transient));
        }

        public Dependancy GetDependancy(Type type)
        {
            return _dependancies.First(d => d.Type.Name == type.Name);
        }
    }
}
