using Core.DataAccess.Repositories;
using Core.Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IUserDal : IRepository<User, Guid>, IAsyncRepository<User, Guid>
{
    List<OperationClaim> GetClaims(User user);
}

