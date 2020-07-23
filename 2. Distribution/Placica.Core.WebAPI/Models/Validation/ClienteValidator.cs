using FluentValidation;

namespace Placica.Core.WebAPI.Models.Validation
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nombre).NotNull().NotEmpty();
            RuleFor(c => c.Apellido).NotNull().NotEmpty();
        }
    }
}