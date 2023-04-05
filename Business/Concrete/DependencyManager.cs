using Business.Abstract;
using Core;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DependencyManager : IDependencyService
    {
        IDependencyDal _dependencyDal;

        public DependencyManager(IDependencyDal dependencyDal)
        {
            _dependencyDal = dependencyDal;
        }

        public void AddDependency(Dependency dependency)
        {
            _dependencyDal.Add(dependency);
        }

        public void DeleteDependency(Dependency dependency)
        {
            _dependencyDal.Delete(dependency);
        }

        public List<Dependency> GetAll()
        {
            return _dependencyDal.GetAll();
        }

        public void UpdateDependency(Dependency dependency)
        {
            throw new NotImplementedException();
        }
    }
}