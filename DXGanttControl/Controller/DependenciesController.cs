using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Controller
{
    public class DependenciesController
    {
        DependencyManager dependencyManager = new DependencyManager(new EfDependencyDal());

        public int Add(Core.Dependency dependency)
        {
            dependencyManager.AddDependency(dependency);
            return dependency.Id;
        }

        public void Delete(Core.Dependency dependency)
        {
            dependencyManager.DeleteDependency(dependency);
        }

        public void Update(Core.Dependency dependency)
        {
            dependencyManager.UpdateDependency(dependency);
        }

        public object GetAllDependencies()
        {
            return dependencyManager.GetAll();
        }
    }
}