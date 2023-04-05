
using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfResourceAssignmentDal : EfEntityRepositoryBase<ResourceAssignment>, IResourceAssignmentDal
    {
    }
}