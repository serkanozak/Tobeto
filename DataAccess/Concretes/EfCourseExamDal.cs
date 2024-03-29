﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;

namespace DataAccess.Concretes;

public class EfCourseExamDal : EfRepositoryBase<CourseExam, Guid, TobetoPlatformContext>, ICourseExamDal
{
    public EfCourseExamDal(TobetoPlatformContext context) : base(context)
    {
    }
}

