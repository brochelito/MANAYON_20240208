using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplator.Application.ProcessData
{
    public class ProcessDataCommandValidator : AbstractValidator<ProcessDataCommand>
    {
        public ProcessDataCommandValidator()
        {
            RuleFor(p => p.ProcessDataRequests)             
                .NotNull();

            RuleFor(p => p.TemplateFileName)
             .NotEmpty().WithMessage("{PropertyName} is required.")
             .NotNull();
        }
    }   
}
