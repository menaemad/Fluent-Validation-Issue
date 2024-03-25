using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using FluentValidation;
using FluentValidationIssue.Authorization.Accounts.Dto;
using FluentValidationIssue.Governments;
using System.Linq;

namespace FluentValidationIssue.Authorization.Accounts.Validations
{
    [UnitOfWork]
    public class RegisterInputValidation : AbstractValidator<RegisterInput>
    {
        private readonly IRepository<Government, int> _governmentRepository;

        public RegisterInputValidation(IRepository<Government, int> governmentRepository)
        {
            RuleFor(x => x.GovernmentId)
     .NotEmpty().WithMessage("Government ID is required.")
     .Must(CheckGovernmentId).WithMessage("Invalid government ID.");

            _governmentRepository = governmentRepository;
        }

        private bool CheckGovernmentId(int governmentId)
            => _governmentRepository.GetAllIncluding().Any(x => x.Id == governmentId); ;
    }
}