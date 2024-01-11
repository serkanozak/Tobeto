using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Core.Entities.Concretes;

namespace DataAccess.Concretes;

public class EfUserDal : EfRepositoryBase<User, Guid, TobetoPlatformContext>, IUserDal
{
    public EfUserDal(TobetoPlatformContext context) : base(context)
    {
    }

    public List<OperationClaim> GetClaims(User user)
    {
        var result = from operationClaim in Context.OperationClaims
                     join userOperationClaim in Context.UserOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                     where userOperationClaim.UserId == user.Id
                     select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
        return result.ToList();
    }
}