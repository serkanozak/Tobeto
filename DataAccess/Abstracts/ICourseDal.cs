using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ICourseDal : IRepository<Course, Guid>, IAsyncRepository<Course, Guid>
{

}

