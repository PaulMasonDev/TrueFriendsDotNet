﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFriendsDotNet.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IFriendRepository Friend { get; }
        ISP_Call SP_Call { get; }

    }
}