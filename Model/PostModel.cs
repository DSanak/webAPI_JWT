using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class PostModel
    {
        public string TestString { get; set; }
        public string TestString2 { get; set; }
    }

    public class PostModelValidator: AbstractValidator<PostModel>
    {
        public PostModelValidator()
        {
            RuleFor(x => x.TestString).NotEmpty().MaximumLength(3);
            RuleFor(x => x.TestString2).NotEmpty().MinimumLength(3);
        }
    }
}
