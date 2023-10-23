using FluentValidation;
using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SP.Domain.Validators
{
    public  class SettingsValidator: AbstractValidator<Settings>
    {

        public SettingsValidator() {
            RuleFor(x => x.NumberOfCertificates)
                .GreaterThan(0)
                .WithMessage(Constants.NumberOfPetsError);

            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Geef een username op !");
        
        }
    }
}
