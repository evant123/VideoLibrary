using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoLibrary.WebUi.Controllers;
using Moq;
using VideoLibrary.WebUi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using VideoLibrary.WebUi.Services;
using Microsoft.Extensions.Logging;

namespace VideoLibrary.UnitTests
{
    [TestClass]
    public class Account
    {
        [TestMethod]
        public void CanLoginWithCorrectEmail()
        {
            var mockUserManager = new Mock<UserManager<ApplicationUser>>();
            var mockSignInManager = new Mock<SignInManager<ApplicationUser>>();
            var mockCookieOptions = new Mock<IOptions<IdentityCookieOptions>>();
            var mockEmailSender = new Mock<IEmailSender>();
            var mockSmsSender = new Mock<ISmsSender>();
            var mockLoggerFactory = new Mock<ILoggerFactory>();
            var mockAccountController = new Mock<AccountController>();

            var controller = new AccountController(mockUserManager, mockSignInManager, mockCookieOptions,
                mockEmailSender, mockSmsSender, mockLoggerFactory);

        }

        [TestMethod]
        public void CantLoginWithIncorrectEmail()
        {
        }

        [TestMethod]
        public void CanLoginWithCorrectUserName()
        {
        }

        [TestMethod]
        public void CantLoginWithIncorrectUserName()
        {
        }

        [TestMethod]
        public void CantLoginWithIncorrectPassword()
        {
        }
    }
}
