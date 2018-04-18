using Abp.EntityFramework;
using LearningMpaAbp.EntityFramework;
using LearningMpaAbp.EntityFramework.Repositories;
using LearningMpaAbp.IRepositories;
using LearningMpaAbp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LearningMpaAbp.Repositories
{
   public class BackendTaskRepository:LearningMpaAbpRepositoryBase<Task>, IBackendTaskRepository
    {
        public BackendTaskRepository(IDbContextProvider<LearningMpaAbpDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
