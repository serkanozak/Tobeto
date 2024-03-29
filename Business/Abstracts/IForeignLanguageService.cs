using Business.Dtos.ForeignLanguage.Requests;
using Business.Dtos.ForeignLanguage.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IForeignLanguageService
{
    Task<IPaginate<GetListedForeignLanguageResponse>> GetListAsync(PageRequest pageRequest);
    Task<CreatedForeignLanguageResponse> AddAsync(CreateForeignLanguageRequest createForeignLanguageRequest);
    Task<UpdatedForeignLanguageResponse> UpdateAsync(UpdateForeignLanguageRequest updateForeignLanguagerequest);
    Task<DeletedForeignLanguageResponse> DeleteAsync(DeleteForeignLanguageRequest deleteForeignLanguageRequest);
    Task<GetForeignLanguageResponse> GetById(GetForeignLanguageRequest getForeignLanguageRequest);
}