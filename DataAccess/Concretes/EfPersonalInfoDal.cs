using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfPersonalInfoDal : EfRepositoryBase<PersonalInfo, Guid, TobetoPlatformContext>, IPersonalInfoDal
{
    public EfPersonalInfoDal(TobetoPlatformContext context) : base(context)
    {
    }
}

