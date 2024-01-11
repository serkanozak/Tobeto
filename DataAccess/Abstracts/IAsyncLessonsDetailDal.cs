using Core.DataAccess.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IAsyncLessonsDetailDal : IRepository<AsyncLessonsDetail, Guid>, IAsyncRepository<AsyncLessonsDetail, Guid>
    {
    }
}
