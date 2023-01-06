using Domain.Framework;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain.CustomerAggregate.Commands.Validations;

namespace Domain.CustomerAggregate.Commands.Command
{
    //Validation   جاش اینجاست
    public class RegisterNewCustomerCommand : CustomerCommand
    {
        public RegisterNewCustomerCommand(long Id, string FirstName, string LastName,
            string PhoneNumber, string NationalCode, long? DetailCustomerInfoId,
            string City, string DetailAddress, string EmailAddress)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.NationalCode = NationalCode;
            this.DetailAddress = DetailAddress;
            this.City = City;
            this.EmailAddress = EmailAddress;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
