using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IAsyncCourseDal : IRepository<AsyncCourse, Guid>, IAsyncRepository<AsyncCourse, Guid>
{

}

