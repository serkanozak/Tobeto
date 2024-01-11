using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfPasswordResetDal : EfRepositoryBase<PasswordReset, Guid, TobetoPlatformContext>, IPasswordResetDal
{
    public EfPasswordResetDal(TobetoPlatformContext context) : base(context)
    {
    }
}

