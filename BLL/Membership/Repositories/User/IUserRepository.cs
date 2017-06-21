using System;
            
namespace Web.TORCHx.Core.BLL.Membership
{
    public interface IUserRepository
    {
		User GetUser(Guid userId);
		User GetUser(string username);
		Membership GetMembership(string username);
	}
}
