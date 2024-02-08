using FluentValidation;

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
