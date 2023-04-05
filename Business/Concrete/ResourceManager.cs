using Business.Abstract;
using Core;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ResourceManager : IResourceService
    {
        IResourceDal _resourceDal;

        public ResourceManager(IResourceDal resourceDal)
        {
            _resourceDal = resourceDal;
        }

        public void AddResource(Resource resource)
        {
            _resourceDal.Add(resource);
        }

        public void DeleteResource(Resource resource)
        {
            _resourceDal.Delete(resource);
        }

        public Resource GetById(int resourceId)
        {
            return _resourceDal.Get(r => r.Id == resourceId);
        }

        public List<Resource> GetAll(Expression<Func<Resource, bool>> filter = null)
        {
            return _resourceDal.GetAll();
        }

        public void UpdateResource(Resource resource)
        {
            throw new NotImplementedException();
        }
    }
}