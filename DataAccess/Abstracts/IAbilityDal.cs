using Core.DataAccess.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IAbilityDal : IRepository<Ability, Guid>, IAsyncRepository<Ability, Guid>
{

}