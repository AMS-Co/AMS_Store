﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
