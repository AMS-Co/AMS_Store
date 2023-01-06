﻿using FluentValidation.Results;
using System.Threading.Tasks;
using Domain.Framework;

namespace Domain.Common
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;

        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}
