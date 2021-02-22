using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueFriendsDotNet.DataAccess.Data;
using TrueFriendsDotNet.DataAccess.Repository.IRepository;
using TrueFriendsDotNet.Models;

namespace TrueFriendsDotNet.DataAccess.Repository
{
    public class FriendRepository : Repository<Friend>, IFriendRepository
    {
        private readonly ApplicationDbContext _db;

        public FriendRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Friend friend)
        {
            var objFromDb = _db.Friends.FirstOrDefault(s => s.Id == friend.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = friend.Name;
                _db.SaveChanges();
            }
        }
    }
}
