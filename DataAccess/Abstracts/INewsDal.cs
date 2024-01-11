using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface INewsDal : IRepository<News, Guid>, IAsyncRepository<News, Guid>
{

}

