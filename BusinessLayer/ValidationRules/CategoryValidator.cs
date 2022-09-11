using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class categoryValidator:AbstractValidator<Category>
    {
        public categoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Olamaz ");
            RuleFor(x=>x.CategoryDesc).NotEmpty().WithMessage("Açıklama Kısmı Boş Olamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı En az 3 Karakter Olmalı");
            RuleFor(x=> x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı En fazla 20 Karakter Olmalı");

        }
    }
}
