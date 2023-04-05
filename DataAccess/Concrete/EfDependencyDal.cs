using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess.Concrete
{
    public class EfDependencyDal : EfEntityRepositoryBase<Dependency>, IDependencyDal
    {
    }
}