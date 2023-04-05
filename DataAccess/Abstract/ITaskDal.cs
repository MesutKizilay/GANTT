using Core.DataAccess.EntityFramework;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITaskDal:IEntityRepository<Task>
    {
    }
}