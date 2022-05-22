using FluentValidation;

namespace Lab4.DTO.Validators
{
    public class TestUserDTOValidator : AbstractValidator<TestUserDTO>
    {
        public TestUserDTOValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(x => x.Phone).NotEmpty().Length(9);
        }
    }
}
