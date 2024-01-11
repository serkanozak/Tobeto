using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfSocialAccountDal : EfRepositoryBase<SocialAccount, Guid, TobetoPlatformContext>, ISocialAccountDal
{
    public EfSocialAccountDal(TobetoPlatformContext context) : base(context)
    {
    }
}

