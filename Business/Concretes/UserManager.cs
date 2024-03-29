using AutoMapper;
using Business.Abstracts;
using Business.Dtos.User.Requests;
using Business.Dtos.User.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
using DataAccess.Abstracts;

namespace Business.Concretes;

public class UserManager : IUserService
{
    IUserDal _userDal;
    IMapper _mapper;

    public UserManager(IUserDal userDal, IMapper mapper)
    {
        _userDal = userDal;
        _mapper = mapper;
    }

    //[ValidationAspect(typeof(UserRequestValidator))]
    public async Task<GetUserResponse> Add(CreateUserRequest request)
    {
        User user = _mapper.Map<User>(request);
        await _userDal.AddAsync(user);
        GetUserResponse response = _mapper.Map<GetUserResponse>(user);
        return response;

    }


    public async Task<GetUserResponse> Delete(DeleteUserRequest request)
    {
        User user = await _userDal.GetAsync(predicate: u => u.Id == request.Id);
        await _userDal.DeleteAsync(user);
        GetUserResponse response = _mapper.Map<GetUserResponse>(user);
        return response;

    }

    public async Task<GetUserResponse> Get(Guid id)
    {
        User user = await _userDal.GetAsync(predicate: u => u.Id == id);
        GetUserResponse response = _mapper.Map<GetUserResponse>(user);
        return response;
    }

    public async Task<GetUserResponse> GetByMail(string email)
    {
        var gettedUser = await _userDal.GetAsync(u => u.Email == email);
        GetUserResponse response = _mapper.Map<GetUserResponse>(gettedUser);
        return response;
    }

    public List<OperationClaim> GetClaims(User user)
    {
        return _userDal.GetClaims(user);
    }

    public async Task<IPaginate<GetListUserResponse>> GetList(PageRequest request)
    {
        var result = await _userDal.GetListAsync(index: request.Index, size: request.Size);
        Paginate<GetListUserResponse> response = _mapper.Map<Paginate<GetListUserResponse>>(result);
        return response;
    }

    public async Task<GetUserResponse> Update(UpdateUserRequest request)
    {
        User updatedUser = _mapper.Map<User>(request);
        await _userDal.UpdateAsync(updatedUser);
        GetUserResponse response = _mapper.Map<GetUserResponse>(updatedUser);
        return response;
    }
}