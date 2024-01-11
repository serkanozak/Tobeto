using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IStudentDal : IRepository<Student, Guid>, IAsyncRepository<Student, Guid>
{

}

