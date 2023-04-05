using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Abstract;
using Business.Concrete;
using Core;
using DataAccess.Concrete;

namespace DXWebApplication1.Controller
{
    public class TasksController
    {
        //ITaskService _taskService;
        TaskManager taskManager = new TaskManager(new EfTaskDal());

        //public TasksController(ITaskService taskService)
        //{
        //    _taskService = taskService;
        //}

        public int Add(Core.Task task)
        {
            taskManager.AddTask(task);
            return task.Id;
        }

        public void Delete(Core.Task task)
        {
            taskManager.DeleteTask(task);
        }

        public void Update(Core.Task task)
        {
            taskManager.UpdateTask(task);
        }

        public object GetAllTasks()
        {
            return taskManager.GetAll();
        }
    }
}