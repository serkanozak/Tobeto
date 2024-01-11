using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IApplicationDal : IRepository<Application, Guid>, IAsyncRepository<Application, Guid>
{

}