using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IAnnouncementsNewsCategoryDal : IRepository<AnnouncementsNewsCategory, Guid>, IAsyncRepository<AnnouncementsNewsCategory, Guid>
{

}

