﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using MyProject.Tasks;

namespace MyProject.IRepositories
{
    /// <summary>
    /// 自定义仓储示例
    /// </summary>
    public interface IBackendTaskRepository : IRepository<TaskEntity>
    {
        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId">用户Id</param>
        /// <returns>任务列表</returns>
        List<TaskEntity> GetTaskByAssignedPersonId(long personId);
    }
}
