﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfCourseDal : EfRepositoryBase<Course, Guid, TobetoPlatformContext>, ICourseDal
{
    public EfCourseDal(TobetoPlatformContext context) : base(context)
    {
    }
}

