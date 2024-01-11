using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ISettingsDal : IRepository<Settings, Guid>, IAsyncRepository<Settings, Guid>
{

}

