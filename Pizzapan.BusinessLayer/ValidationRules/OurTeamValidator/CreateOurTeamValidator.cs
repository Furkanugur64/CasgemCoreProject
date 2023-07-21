using FluentValidation;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.ValidationRules.OurTeamValidator
{
    public class CreateOurTeamValidator: AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator()
        {
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalı");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Başlık en fazla 30 karakter olmalı");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı Boş Geçilemez");
        }
    }
}
