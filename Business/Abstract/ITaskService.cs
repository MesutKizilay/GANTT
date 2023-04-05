using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskService
    {   
        void AddTask(Task task);
        void DeleteTask(Task task);     
        void UpdateTask(Task task);
        List<Task> GetAll();        
    }
}