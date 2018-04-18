using Abp.Domain.Repositories;
using LearningMpaAbp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LearningMpaAbp.IRepositories
{
    public interface IBackendTaskRepository:IRepository<Task>
    {
        //继承IRepository 的泛型接口.
    }
}
