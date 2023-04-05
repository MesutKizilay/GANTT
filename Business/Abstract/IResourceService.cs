using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IResourceService
    {
        void AddResource(Resource resource);
        void DeleteResource(Resource resource);
        void UpdateResource(Resource resource);
        List<Resource> GetAll(Expression<Func<Resource, bool>> filter = null);
        Resource GetById(int resourceId);
    }
}