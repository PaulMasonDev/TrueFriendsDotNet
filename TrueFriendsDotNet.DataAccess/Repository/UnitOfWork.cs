using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueFriendsDotNet.DataAccess.Data;
using TrueFriendsDotNet.DataAccess.Repository.IRepository;

namespace TrueFriendsDotNet.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Friend = new FriendRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public IFriendRepository Friend { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
