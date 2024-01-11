using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IInstructorDal : IRepository<Instructor, Guid>, IAsyncRepository<Instructor, Guid>
{

}

