using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace DXWebApplication1.Controller
{
    public class ResourcesController
    {
        ResourceManager resourceManager = new ResourceManager(new EfResourceDal());
        //static HttpSessionState Session { get { return HttpContext.Current.Session; } }

        //public List<Core.Resource> GetResources() { return Resources; }



        public List<Core.Resource> GetAllResources()
        {
            return resourceManager.GetAll();
        }


        //public List<Core.Resource> Resources
        //{
        //    get
        //    {
        //        if (Session[ResourcesSessionKey] == null)
        //            Session[ResourcesSessionKey] = GetAllResources();
        //        return ((List<Core.Resource>)Session[ResourcesSessionKey]);
        //    }
        //}


        public int Add(Core.Resource resource)
        {
            resourceManager.AddResource(resource);
            //var resourceToAdd = resourceManager.GetById(resource.Id);
            //Resources.Add(resourceToAdd);

            return resource.Id;
        }

        public void Delete(Core.Resource resource)
        {
            //var resourceToDelete = Resources.FirstOrDefault(r => r.Id==resource.Id);
            //if (resourceToDelete != null)
            //    Resources.Remove(resourceToDelete);
            resourceManager.DeleteResource(resource);
        }

        public void Update(Core.Resource resource)
        {
            resourceManager.UpdateResource(resource);
        }


















        const string TasksSessionKey = "Tasks",
        DependenciesSessionKey = "Dependencies",
        ResourcesSessionKey = "Resources",
        ResourceAssignmentsSessionKey = "ResourceAssignments";
    }
}