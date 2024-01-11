using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ICourseExamDal : IRepository<CourseExam, Guid>, IAsyncRepository<CourseExam, Guid>
{

}

