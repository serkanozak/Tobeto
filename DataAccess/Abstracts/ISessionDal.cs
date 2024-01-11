using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ISessionDal : IRepository<Session, Guid>, IAsyncRepository<Session, Guid>
{

}

