using System;
using System.Linq;

namespace Web.TORCHx.Core.BLL.Membership
{
    public class UserRepository : IUserRepository
    {
		private readonly MembershipContext _context;

		public UserRepository(MembershipContext context)
		{
			_context = context;
		}

		public User GetUser(Guid userId)
		{
			return _context.Users
				           .Where(u => u.UserId == userId)
				           .FirstOrDefault();
		}

		public User GetUser(string username)
		{
			return _context.Users
				           .Where(u => u.UserName == username)
				           .FirstOrDefault();
		}

		public Membership GetMembership(string username)
		{
			return _context.Memberships
				           .Where(u => u.User.UserName == username)
				           .FirstOrDefault();
		}
    }
}
