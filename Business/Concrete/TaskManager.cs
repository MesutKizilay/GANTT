using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public void AddTask(Task task)
        {
            _taskDal.Add(task);
        }

        public void DeleteTask(Task task)
        {
            _taskDal.Delete(task);
        }

        public List<Task> GetAll()
        {
            return _taskDal.GetAll();
        }

        public void UpdateTask(Task task)
        {
            _taskDal.Update(task);
        }
    }
}