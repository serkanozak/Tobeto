using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ISocialAccountDal : IRepository<SocialAccount, Guid>, IAsyncRepository<SocialAccount, Guid>
{

}

