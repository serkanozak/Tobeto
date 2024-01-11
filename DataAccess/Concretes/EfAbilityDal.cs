using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class EfAbilityDal : EfRepositoryBase<Ability, Guid, TobetoPlatformContext>, IAbilityDal
{
    public EfAbilityDal(TobetoPlatformContext context) : base(context)
    {
    }
}

