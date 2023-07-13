using FluentValidation;
using SipayBootcamp.SampleApi.Model;
using System.Text.RegularExpressions;

namespace SipayBootcamp.SampleApi.Validators
{
    public class CreatePersonValidator : AbstractValidator<Person>
    {
        public CreatePersonValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                    .WithMessage("Staff Salary is required.")
                .NotNull()
                    .WithMessage("Staff person name is required.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Staff person name must be between 5 and 100 characters.");

            RuleFor(p => p.Lastname)
                
                .NotEmpty()
                    .WithMessage("Staff Salary is required.")
                .NotNull()
                    .WithMessage("Staff person lastname is required.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Staff person lastname must be between 5 and 100 characters.");

            RuleFor(p => p.Phone)
                .NotEmpty()
                    .WithMessage("Staff Salary is required.")
                .NotNull()
                    .WithMessage("Staff phone number is required.")
                .Length(1, 11)
                    .WithMessage("Staff phone number to must be between 1 and 5.")
                .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"))
                    .WithMessage("Staff phone number not valid");

            RuleFor(p => p.AccessLevel)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Staff access level is required.")
                .Must(x => x >= 0)
                    .WithMessage("Staff access level information cannot be negative!")
                .ExclusiveBetween(1, 10).WithMessage("Staff access level to must be between 1 and 5.");

            RuleFor(p => p.Salary)
                .NotEmpty()
                    .WithMessage("Staff Salary is required.")
                .NotNull()
                    .WithMessage("Staff Salary is required.")
                .Must(x => x >= 0)
                    .WithMessage("Staff salary information cannot be negative!");

        }
    }
}
