using FluentValidation;
using TT.Api.Data.Model;

namespace TT.Api.Validations
{
    public class PostValidator : AbstractValidator<PostDto>
    {
        public PostValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş olamaz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş olamaz");
        }
    }
}
