using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using MyProject.IRepositories;
using MyProject.Tasks;


namespace MyProject.EntityFramework.Repositories
{
    public class BackendTaskRepository : MyProjectRepositoryBase<TaskEntity>,IBackendTaskRepository
    {
        public BackendTaskRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }


        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId">用户Id</param>
        /// <returns>任务列表</returns>
        public List<TaskEntity> GetTaskByAssignedPersonId(long personId)
        {
            var query = GetAll();

            if (personId > 0)
            {
                query = query.Where(t => t.AssignedPersonId == personId);
            }

            return query.ToList();
        }

    }
}
