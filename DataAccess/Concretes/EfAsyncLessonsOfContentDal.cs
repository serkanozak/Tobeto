﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfAsyncLessonsOfContentDal : EfRepositoryBase<AsyncLessonsOfContent, Guid, TobetoPlatformContext>, IAsyncLessonsOfContentDal
{
    public EfAsyncLessonsOfContentDal(TobetoPlatformContext context) : base(context)
    {
    }
}

