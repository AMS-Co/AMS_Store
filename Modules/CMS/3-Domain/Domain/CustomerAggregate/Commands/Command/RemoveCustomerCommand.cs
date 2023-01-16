﻿using Domain.CustomerAggregate.Commands.Validations;

namespace Domain.CustomerAggregate.Commands.Command
{
    public class RemoveCustomerCommand : CustomerCommand
    {
        public RemoveCustomerCommand(long id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}