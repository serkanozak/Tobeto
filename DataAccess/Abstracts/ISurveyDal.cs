using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface ISurveyDal : IRepository<Survey, Guid>, IAsyncRepository<Survey, Guid>
{

}

