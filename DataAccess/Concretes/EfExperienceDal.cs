using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfExperienceDal : EfRepositoryBase<Experience, Guid, TobetoPlatformContext>, IExperienceDal
{
    public EfExperienceDal(TobetoPlatformContext context) : base(context)
    {
    }
}

