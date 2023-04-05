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
    public class ResourceAssignmentManager : IResourceAssignmentService
    {
        IResourceAssignmentDal _resourceAssignmentDal;

        public ResourceAssignmentManager(IResourceAssignmentDal resourceAssignmentDal)
        {
            _resourceAssignmentDal = resourceAssignmentDal;
        }

        public void AddResourceAssignment(ResourceAssignment resourceAssignment)
        {
            _resourceAssignmentDal.Add(resourceAssignment);
        }

        public void DeleteResourceAssignment(ResourceAssignment resourceAssignment)
        {
            _resourceAssignmentDal.Delete(resourceAssignment);
        }

        public List<ResourceAssignment> GetAll()
        {
            return _resourceAssignmentDal.GetAll();
        }

        public void UpdateResourceAssignment(ResourceAssignment resourceAssignment)
        {
            throw new NotImplementedException();
        }
    }
}
