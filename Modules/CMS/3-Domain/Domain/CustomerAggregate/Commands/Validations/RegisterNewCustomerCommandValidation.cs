using Domain.CustomerAggregate.Commands.Command;

namespace Domain.CustomerAggregate.Commands.Validations
{
    public class RegisterNewCustomerCommandValidation : CustomerValidation<RegisterNewCustomerCommand>
    {
        public RegisterNewCustomerCommandValidation()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidatePhoneNumber();
            ValidateEmail();
            ValidateId();
            ValidateNationalCode();
            ValidateCity();
            ValidateDetailAddress();
        }
    }
}