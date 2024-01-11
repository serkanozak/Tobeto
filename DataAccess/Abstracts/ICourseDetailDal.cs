using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ICourseDetailDal : IRepository<CourseDetail, Guid>, IAsyncRepository<CourseDetail, Guid>
{

}

