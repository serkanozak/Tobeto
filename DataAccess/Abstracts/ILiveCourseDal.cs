using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ILiveCourseDal : IRepository<LiveCourse, Guid>, IAsyncRepository<LiveCourse, Guid>
{

}

