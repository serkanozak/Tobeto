using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfAsyncLessonsDetailDal : EfRepositoryBase<AsyncLessonsDetail, Guid, TobetoPlatformContext>, IAsyncLessonsDetailDal
    {
        public EfAsyncLessonsDetailDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
