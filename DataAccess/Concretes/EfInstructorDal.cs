﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, TobetoPlatformContext>, IInstructorDal
{
    public EfInstructorDal(TobetoPlatformContext context) : base(context)
    {
    }
}

