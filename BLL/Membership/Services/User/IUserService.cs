using System;

namespace Web.TORCHx.Core.BLL.Membership
{
    public interface IUserService
    {
		User GetUser(Guid id);
		User GetUser(string username);
		bool ValidateUser(string username, string password);
	}
}
