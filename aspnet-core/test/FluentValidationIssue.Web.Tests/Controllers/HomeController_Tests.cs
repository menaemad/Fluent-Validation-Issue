using System.Threading.Tasks;
using FluentValidationIssue.Models.TokenAuth;
using FluentValidationIssue.Web.Controllers;
using Shouldly;
using Xunit;

namespace FluentValidationIssue.Web.Tests.Controllers
{
    public class HomeController_Tests: FluentValidationIssueWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}