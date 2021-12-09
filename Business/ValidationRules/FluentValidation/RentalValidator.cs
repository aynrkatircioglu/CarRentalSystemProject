using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    internal class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentStartDate).LessThan(r => r.RentEndDate);
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.RentStartDate);
        }
    }
}