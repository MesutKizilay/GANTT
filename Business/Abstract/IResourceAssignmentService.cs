using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface IResourceAssignmentService
    {
        void AddResourceAssignment(ResourceAssignment resourceAssignment);
        void DeleteResourceAssignment(ResourceAssignment resourceAssignment);
        void UpdateResourceAssignment(ResourceAssignment resourceAssignment);
        List<ResourceAssignment> GetAll();
    }
}