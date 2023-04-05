using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfTaskDal: EfEntityRepositoryBase<Task>, ITaskDal
    {
    }
}