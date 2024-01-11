using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfCourseCategoryDal : EfRepositoryBase<CourseCategory, Guid, TobetoPlatformContext>, ICourseCategoryDal
{
    public EfCourseCategoryDal(TobetoPlatformContext context) : base(context)
    {
    }
}

