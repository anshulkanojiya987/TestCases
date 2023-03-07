
using BionicApp.Pages.Add_Device;
using Moq;
using Bunit;
using Microsoft.JSInterop;
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
using FluentAssertions.Common;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Components;

namespace BionicAppTestRunner.BionicAppUi
{
    public class UserUI : BionicAppUiTestBase
    {
        [Fact]
        public void AllFields_AreDisplayed()
        {
            var component = RenderComponent<User>();
            var nameText = component.FindComponents<MudField>();
            var emailText = component.FindComponent<MudField>();
            var logOutButton = component.FindComponent<MudButton>();
            Assert.NotNull(nameText);
            Assert.NotNull(emailText);
            Assert.NotNull(logOutButton);
        }
        [Fact]
        public void checkmainStackPro()
        {
            var component = RenderComponent<User>();
            var mudStack = component.FindComponent<MudStack>();
            Assert.Equal("ma-2 pa-3 stackLayout", mudStack.Instance.Class);
        }

        [Fact]
        public void check1stMudstackProperty()
        {
            var component = RenderComponent<User>();
            var Stack = component.FindComponent<MudStack>();
            var firstStack = Stack.FindComponent<MudStack>();
            Assert.Equal(AlignItems.Center, firstStack.Instance.AlignItems);
            Assert.Equal(Justify.Center, firstStack.Instance.Justify);
            Assert.Equal(2, firstStack.Instance.Spacing);
        }
        [Fact]
        public void checkMudTextin1stmudStack()
        {
            var component = RenderComponent<User>();
            var Stack = component.FindComponent<MudStack>();
            var firstStack = Stack.FindComponent<MudStack>();
            var mudText = firstStack.FindComponent<MudText>();
            Assert.Equal(Align.Center, mudText.Instance.Align);
            Assert.Equal(Typo.h6, mudText.Instance.Typo);
            mudText.Find("b").MarkupMatches("<b>user_ua</b>");

        }
        [Fact]
        public void checkMudAvtar()
        {
            var component = RenderComponent<User>();
            var avtar = component.FindComponent<MudAvatar>();
            Assert.NotNull(avtar);
            Assert.Equal(MudBlazor.Color.Primary, avtar.Instance.Color);
            Assert.Equal(MudBlazor.Size.Large, avtar.Instance.Size);
        }

        [Fact]
        public void checkNameMudField()
        {
            var component = RenderComponent<User>();
            var name = component.FindComponent<MudField>();
            Assert.Equal("name_ua", name.Instance.Label);
            Assert.NotNull(name.Instance.Label);
            Assert.Equal(Variant.Text, name.Instance.Variant);
        }

        [Fact]
        public void checkEmailMudField()
        {
            var email = RenderComponent<MudField>(p =>
                p.Add(x => x.Label, "Email")
            );
            Assert.NotNull(email.Instance.Label);
            Assert.Equal("Email", email.Instance.Label);
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
        public void checkLogoutButtonProperty() 
        {
            var component = RenderComponent<User>();
            var LogoutButton = component.FindComponent<MudButton>();
            Assert.NotNull(LogoutButton);
            Assert.Equal(MudBlazor.Color.Primary,LogoutButton.Instance.Color);
            Assert.Equal("height:52px; text-transform:none;", LogoutButton.Instance.Style);
        }

        [Fact]
        public async void checkMudSelect()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, System.DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            Manager.Instance.GetSupportedLanguages();
            var component = RenderComponent<User>();
            var LanSelect = component.FindComponent<MudSelect<string>>();
            Assert.NotNull(LanSelect);
            Assert.False(LanSelect.Instance.MultiSelection);
            Assert.Equal(Variant.Outlined, LanSelect.Instance.Variant);
            Assert.Equal(Origin.BottomCenter, LanSelect.Instance.AnchorOrigin);
            Assert.False(LanSelect.Instance.MultiSelection);
            Assert.Equal("English", LanSelect.Instance.Value);
        }



        [Fact]
        public async void NameTest()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            var component = RenderComponent<User>();
            var mudfield = component.FindComponent<MudField>();
            var mudtext = mudfield.FindComponent<MudText>();
            mudtext.Find("p").MarkupMatches("<p class=\"mud-typography mud-typography-body2\">Test User Admin</p>");
        }


        [Fact]
        public void EmailTest()
        {
            var component = RenderComponent<MudText>(parameters => parameters
               .Add(p => p.Typo, Typo.body2)
               .AddChildContent("@email")
           );

            var header = component.Find("body2");
            Assert.NotNull(header);
            Assert.Equal("@email", header.InnerHtml);

        }

        [Fact]
        public void RoleTest()
        {
            var component = RenderComponent<MudText>(parameters => parameters
               .Add(p => p.Typo, Typo.body2)
               .AddChildContent("@role")
           );

            var header = component.Find("body2");
            Assert.NotNull(header);
            Assert.Equal("@role", header.InnerHtml);

        }

        [Fact]
        public void AvtarTest()
        {
            var component = RenderComponent<MudText>(parameters => parameters
               .Add(p => p.Typo, Typo.body2)
               .AddChildContent("@avatar")
           );

            var header = component.Find("body2");
            Assert.NotNull(header);
            Assert.Equal("@avatar", header.InnerHtml);

        }
        [Fact]
        public void CheckButtonNevigation()
        {
            var component = RenderComponent<User>();
            var nav = component.Services.GetRequiredService<NavigationManager>();
            var button = component.FindComponent<MudButton>();
            var buttonclick = button.Instance.OnClick;
            Assert.Equal("/", nav.Uri);
        }
        [Fact]

        public async void CheckMudSelectItem()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            var component = RenderComponent<User>();
            var mudselit = component.FindComponent<MudSelectItem<string>>();
            Assert.Equal("english", mudselit.Instance.Value);
        }
    }
}
