using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IPersonalInfoDal : IRepository<PersonalInfo, Guid>, IAsyncRepository<PersonalInfo, Guid>
{

}

