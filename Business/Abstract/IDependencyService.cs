using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface IDependencyService
    {
        void AddDependency(Dependency dependency);
        void DeleteDependency(Dependency dependency);
        void UpdateDependency(Dependency dependency);
        List<Dependency> GetAll();
    }
}
