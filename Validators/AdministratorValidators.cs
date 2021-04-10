using drugstore.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Validators
{
    public class AdministratorValidators : AbstractValidator<Administrator>
    {
        public AdministratorValidators()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.Password).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.TelephoneNumber).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("Telephone number must have format: [2-9][0-9]{10}");
            RuleFor(x => x.Sex).NotNull().NotEmpty().Must(IsMaleOrFemale).WithMessage("Sex need to be M or F");

        }

        private bool IsMaleOrFemale(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}
