using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    { //kuralar buraya yazılır
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();//boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0);//den büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartwithA).WithMessage("Ürünler A harfi ile başlamalı");//kendi kuralım böyle yazarım
            
        }

        private bool StartwithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
