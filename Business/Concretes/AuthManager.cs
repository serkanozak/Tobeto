using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Dtos.Auth.Requests;
using Business.Dtos.Auth.Responses;
using Business.Dtos.User.Requests;
using Business.Dtos.User.Responses;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concretes;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;

namespace Business.Concrete;

public class AuthManager : IAuthService
{
    private IUserService _userService;
    private ITokenHelper _tokenHelper;
    private IMapper _mapper;

    public AuthManager(IUserService userService, ITokenHelper tokenHelper, IMapper mapper)
    {
        _userService = userService;
        _tokenHelper = tokenHelper;
        _mapper = mapper;
    }

    public async Task<RegisterAuthResponse> Register(RegisterAuthRequest request, string password)
    {
        User user = _mapper.Map<User>(request);
        var existingUser = await _userService.GetByMail(user.Email);

        if (existingUser != null)
        {
            throw new BusinessException(UserMessages.UserNotBeExist);
        }

        byte[] passwordHash, passwordSalt;
        HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
        user.PasswordHash = passwordHash;
        user.PasswordSalt = passwordSalt;

        CreateUserRequest createUserRequest = _mapper.Map<CreateUserRequest>(user);
        GetUserResponse createdUser = await _userService.Add(createUserRequest);
        RegisterAuthResponse response = _mapper.Map<RegisterAuthResponse>(createdUser);
        return response;
    }

    public async Task<LoginAuthResponse> Login(LoginAuthRequest request)
    {
        User user = _mapper.Map<User>(request);
        var loginuser = await _userService.GetByMail(user.Email);

        if (loginuser == null)
        {
            //LoginUserResponse response = _mapper.Map<LoginUserResponse>(user);
            //return new Task<response>(user, Messages.UserNotBeExist);
            throw new BusinessException(UserMessages.UserNotBeExist);
        }

        if (!HashingHelper.VerifyPasswordHash(request.Password, loginuser.PasswordHash, loginuser.PasswordSalt))
        {
            throw new BusinessException(UserMessages.PasswordUncorrect);
        }

        LoginAuthResponse response = _mapper.Map<LoginAuthResponse>(loginuser);
        return response;
    }

    //public Task UserExists(string email)
    //{
    //    if (_userService.GetByMail(email) != null)
    //    {

    //        throw new BusinessException(Messages.UserAlreadyExists);
    //    }
    //    return new BusinessEx();
    //}

    public AccessToken CreateAccessToken(LoginAuthResponse loginAuthResponse)
    {
        User user = _mapper.Map<User>(loginAuthResponse);
        var claims = _userService.GetClaims(user);
        var accessToken = _tokenHelper.CreateToken(user, claims);
        return accessToken;
    }
}