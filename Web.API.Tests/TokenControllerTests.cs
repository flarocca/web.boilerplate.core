using System;
﻿using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Web.TORCHx.Core.Web.API;
using Web.TORCHx.Core.BLL.Membership;
using Web.TORCHx.Core.Web.Common;
using System.Reflection;

namespace Web.TORCHx.Core.Web.API.Tests
{
	public class TokenControllerTests
	{
		[Fact]
		public void Get_With_Success_Returns_Token()
		{
			//Arrange
			var token = "abc123";
			var userId = Guid.NewGuid();
			var mockHttpAccessorService = HttpContextAccessorMocks.MockReturningUserId(userId);
			var mockTokenService = TokenServiceMocks.MockReturningGenerateToken(token);

			//Act
			var tokenController = new TokenController(mockHttpAccessorService, null, mockTokenService);
			var result = (SuccessResult)tokenController.Get();
			var response = (SuccessResponse)result.Value;

			//Assert
			Assert.Equal(response.Data, token);
		}

		[Fact]
		public void Get_With_Failure_Returns_Unauthorized()
		{
			//Arrange
			var userId = Guid.NewGuid();
			var mockHttpAccessorService = HttpContextAccessorMocks.MockReturningUserId(userId);
			var mockTokenService = TokenServiceMocks.MockReturningGenerateToken(null);

			//Act
			var tokenController = new TokenController(mockHttpAccessorService, null, mockTokenService);
			IActionResult result = tokenController.Get();

			//Assert
			Assert.True(result is UnauthorizedResult);
		}

		[Fact]
		public void Get_Has_Authorize_Attribute()
		{
			var attribute = typeof(TokenController).GetMethod(nameof(TokenController.Get)).GetCustomAttribute<AuthorizeAttribute>();
			Assert.NotNull(attribute);
		}

		[Fact]
		public void Post_With_Success_Returns_Token()
		{
			//Arrange
			var token = "abc123";
			var userId = Guid.NewGuid();
			var user = new User();
			user.UserId = userId;
			var mockUserService = UserServiceMocks.MockReturningValidateAndGetUser(user);
			var mockTokenService = TokenServiceMocks.MockReturningGenerateToken(token);

			//Act
			var request = new TokenRequest();
			var tokenController = new TokenController(null, mockUserService, mockTokenService);
			var result = (SuccessResult)tokenController.Post(request);
			var response = (SuccessResponse)result.Value;

			//Assert
			Assert.Equal(response.Data, token);
		}

		[Fact]
		public void Post_With_Failure_Returns_Unauthorized()
		{
			//Arrange
			var mockUserService = UserServiceMocks.MockReturningValidateUser(false);
			var mockTokenService = TokenServiceMocks.MockReturningGenerateToken(null);

			//Act
			var request = new TokenRequest();
			var tokenController = new TokenController(null, mockUserService, mockTokenService);
			IActionResult result = tokenController.Post(request);

			//Assert
			Assert.True(result is UnauthorizedResult);
		}

		[Fact]
		public void Post_Has_Validate_Model_Attribute()
		{
			var attribute = typeof(TokenController).GetMethod(nameof(TokenController.Post)).GetCustomAttribute<ValidateModelAttribute>();
			Assert.NotNull(attribute);		
		}
	}
}
