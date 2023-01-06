using Domain.CustomerAggregate.Commands.Command;

namespace Domain.CustomerAggregate.Commands.Validations
{
    public class UpdateCustomerCommandValidation : CustomerValidation<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidation()
        {
            {
                ValidateFirstName();
                ValidateLastName();
                ValidatePhoneNumber();
                ValidateEmail();
                ValidateNationalCode();
                ValidateCity();
                ValidateDetailAddress();
            }
        }
    }
}