using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ILiveContentDal : IRepository<LiveContent, Guid>, IAsyncRepository<LiveContent, Guid>
{

}

