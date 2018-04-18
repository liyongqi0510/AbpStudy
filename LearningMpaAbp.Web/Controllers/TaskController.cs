using LearningMpaAbp.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMpaAbp.Web.Controllers
{
    public class TaskController : Controller
    {
        public IBackendTaskRepository _taskRepository { get; set; }
        
        //根据构造方法依赖注入. 
        public TaskController(IBackendTaskRepository taskRepository) {
            _taskRepository = taskRepository;
        }
        // GET: Task
        public ActionResult Index()
        {
            var model=_taskRepository.GetAll();
            return View();
        }
    }
}