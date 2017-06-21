using System.Threading.Tasks;
using Web.TORCHx.Core.BLL.Membership;
using Moq;

namespace Web.TORCHx.Core.Web.API.Tests
{
	public static class UserServiceMocks
	{
		public static IUserService MockReturningValidateUser(bool isValid)
		{
			var mock = new Mock<IUserService>();
			mock.Setup(x => x.ValidateUser(It.IsAny<string>(), It.IsAny<string>()))
				.Returns(isValid);
			return mock.Object;
		}

		public static IUserService MockReturningValidateAndGetUser(User user)
		{
			var mock = new Mock<IUserService>();
			mock.Setup(x => x.ValidateUser(It.IsAny<string>(), It.IsAny<string>()))
				.Returns(true);
			mock.Setup(x => x.GetUser(It.IsAny<string>()))
				.Returns(user);
			return mock.Object;
		}
	}
}
