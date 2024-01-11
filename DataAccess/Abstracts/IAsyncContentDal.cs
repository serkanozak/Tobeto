using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IAsyncContentDal : IRepository<AsyncContent, Guid>, IAsyncRepository<AsyncContent, Guid>
{

}

