using AngleSharp.Css.Dom;
using AngleSharp.Dom;
using BionicApp.Pages.Add_Device;
using BionicApp.Pages.Add_Device.App_Info;
using BionicApp.Pages.Add_Device.My_Devices.DeviceSettings;
using BionicApp.Pages.Authentication;
using BionicAppTestRunner.BionicApp;
using Bogus.DataSets;
using Bunit;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MudBlazor;
using Ossur.Bionics.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;
using static MudBlazor.CategoryTypes;
using static MudBlazor.FilterOperator;

namespace BionicAppTestRunner.BionicAppUi
{
    public class UserUI : BionicAppUiTestBase 
    {
        [Fact]
        public void AllFields_AreDisplayed()
        {
            var component = RenderComponent<User>();
            //var nameText = component.FindComponent<MudField>();
            //var emailText = component.FindComponent<MudField>();
            var logOutButton = component.FindAll("button").FirstOrDefault(b => b.TextContent == "Log out");
            //Assert.NotNull(nameText);
            //Assert.NotNull(emailText);
            Assert.NotNull(logOutButton);
        }
       
       
        [Fact]
        public void checkMudAvtar()
        {
            var avtar = RenderComponent<MudAvatar>(p =>
                p.Add(x => x.Color, MudBlazor.Color.Primary)
                 .Add(x => x.Size, MudBlazor.Size.Large)
            );
            Assert.NotNull(avtar);
            Assert.Equal(MudBlazor.Color.Primary, avtar.Instance.Color);
            Assert.Equal(MudBlazor.Size.Large, avtar.Instance.Size);
        }

        [Fact]
        public void checkNameMudField()
        {
            var name = RenderComponent<MudField>(p =>
                p.Add(x => x.Label, "Name")
            );
            Assert.NotNull(name.Instance.Label);
            Assert.Equal("Name", name.Instance.Label);
            Assert.Equal(Variant.Text, name.Instance.Variant);
        }

        [Fact]
        public void checkEmailMudField()
        {
            var email = RenderComponent<MudField>(p =>
                p.Add(x => x.Label, "Email")
            );
            Assert.NotNull(email.Instance.Label);
            Assert.Equal("Name", email.Instance.Label);
            Assert.Equal(Variant.Text, email.Instance.Variant);
        }

        [Fact]
        public void checkRoleMudField()
        {
            var role = RenderComponent<MudField>(p =>
                p.Add(x => x.Label, "Role")
            );
            Assert.NotNull(role.Instance.Label);
            Assert.Equal("Role", role.Instance.Label);
            Assert.Equal(Variant.Text, role.Instance.Variant);
        }

        [Fact]
        public void checkLanguageMudText()
        {
            var language = RenderComponent<MudText>(p =>
                p.Add(x => x.Align, Align.Center)
             //   .Add(x => x.Typo, "Typo.h6")
            );
            Assert.Equal(Align.Center, language.Instance.Align);
        }


        [Fact]
        public void checkLogoutButton() 
        {
            // Arrange
            var LogoutButton = RenderComponent<MudButton>(p =>
                p.Add(x => x.Style, "height:52px; text-transform:none;")
                .Add(x => x.Color, MudBlazor.Color.Primary)
            );
            Assert.NotNull(LogoutButton);
            Assert.Equal(MudBlazor.Color.Primary,LogoutButton.Instance.Color);
            Assert.Equal("height:52px; text-transform:none;", LogoutButton.Instance.Style);
        }

        [Fact]
        public void checkUser()
        {
            var component = RenderComponent<Info>();
            //var languages = component.FindComponent<MudSelect<SelectionMode>>();
            //var lancount = languages.RenderCount;
            //Assert.Equal(18, lancount);
        }


        //[Fact]
        //public async void NameTest()
        //{
        //    await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
        //    using var ctx = new TestContext();

        //    var lines = "Test User Admin";

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add(p => p.name, lines)
        //    );

        //}

        //[Fact]
        //public async void SelectedLanguageTest()
        //{
        //    await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
        //    using var ctx = new TestContext();
        //    //List<string> myList = new List<string>() 
        //    //{
        //    //    "English",
        //    //};
        //    var lines = "English";
        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add(p => p.selectedLanguage, lines)
        //    );

        //}

        //[Fact]
        //public async void EmailTest()
        //{
        //    await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
        //    using var ctx = new TestContext();

        //    var lines = "Tst_admin@example.com";

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add(p => p.email, lines)
        //    );

        //}

        //[Fact]
        //public async void RoleTest()
        //{
        //    await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
        //    using var ctx = new TestContext();

        //    var lines = "Admin";

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add(p => p.role, lines)
        //    );

        //}

        //[Fact]
        //public async void AvtarTest()
        //{
        //    await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
        //    using var ctx = new TestContext();

        //    var lines = "T";

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add(p => p.avatar, lines)
        //    );

        //}

        //[Fact]
        //public void Test()
        //{
        //    using var ctx = new TestContext();

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add<Alert>(p => p.Content, alertParameters => alertParameters
        //        .Add(p => p.name, "Alert heading")

        //      )
        //    );
        //}


    }
}
