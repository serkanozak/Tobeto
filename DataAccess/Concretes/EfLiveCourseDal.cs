﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfLiveCourseDal : EfRepositoryBase<LiveCourse, Guid, TobetoPlatformContext>, ILiveCourseDal
{
    public EfLiveCourseDal(TobetoPlatformContext context) : base(context)
    {
    }
}

