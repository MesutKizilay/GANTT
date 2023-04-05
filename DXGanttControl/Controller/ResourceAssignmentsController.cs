using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Controller
{
    public class ResourceAssignmentsController
    {
        ResourceAssignmentManager resourceAssignmentManager = new ResourceAssignmentManager(new EfResourceAssignmentDal());

        public int Add(Core.ResourceAssignment resourceAssignment)
        {
            resourceAssignmentManager.AddResourceAssignment(resourceAssignment);
            return resourceAssignment.Id;
        }

        public void Delete(Core.ResourceAssignment resourceAssignment)
        {
            resourceAssignmentManager.DeleteResourceAssignment(resourceAssignment);
        }

        public void Update(Core.ResourceAssignment resourceAssignment)
        {
            resourceAssignmentManager.UpdateResourceAssignment(resourceAssignment);
        }

        public object GetAllResourceAssignments()
        {
            return resourceAssignmentManager.GetAll();
        }
    }
}