using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueFriendsDotNet.Models;

namespace TrueFriendsDotNet.DataAccess.Repository.IRepository
{
    public interface IFriendRepository : IRepository<Friend>
    {
        void Update(Friend friend);
    }
}
