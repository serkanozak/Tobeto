using Business.Constants;
using Business.Dtos.Auth.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class UserRequestValidator : AbstractValidator<RegisterAuthRequest>
{
    public UserRequestValidator()
    {
        RuleFor(r => r.FirstName).MinimumLength(2).NotEmpty().WithMessage(UserMessages.MustContainAtMinTwoChar);
        RuleFor(r => r.LastName).MinimumLength(2).NotEmpty().WithMessage(UserMessages.MustContainAtMinTwoChar);
        RuleFor(r => r.Email).NotEmpty().EmailAddress();
        RuleFor(r => r.Password).MinimumLength(8).MaximumLength(10).NotEmpty().WithMessage(UserMessages.MustContainAtMinTwoChar).WithMessage(UserMessages.MustContainAtMaxTenChar);

    }
}