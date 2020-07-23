using FluentValidation;

namespace Placica.Core.WebAPI.Models.Validation
{
    public class LoginModelValidator : AbstractValidator<LoginModel>
    {
        public LoginModelValidator()
        {
            RuleFor(m => m.EmailAddress).NotNull().NotEmpty();
            RuleFor(m => m.FirstName).NotNull().NotEmpty();
            RuleFor(m => m.LastName).NotNull().NotEmpty();
            RuleFor(m => m.PictureUrl).NotNull().NotEmpty();
            RuleFor(m => m.Provider).NotNull().NotEmpty();
            RuleFor(m => m.UserId).NotNull().NotEmpty();
        }
    }
}