using BionicApp.Pages.Add_Device.My_Devices.DeviceProfiles;
using Bunit;
using MudBlazor;
using Ossur.Bionics.Common;
using System.Globalization;
using Xunit;
using Color = MudBlazor.Color;

namespace BionicAppTestRunner.BionicAppUi
{
    public class CreateProfileTest : BionicAppUiTestBase
    {
        [Fact]
        public void MudStack1_Test()
        {
            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var stack = comp.FindComponents<MudStack>()[0];

            Assert.Equal(2, stack.Instance.Spacing);
            Assert.Equal("pa-4", stack.Instance.Class);
            Assert.False(stack.Instance.Row);
            Assert.NotNull(stack);
        }

        [Fact]
        public void GridAnd_Icon()
        {
            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var grid = comp.FindComponents<MudGrid>()[0];
            var iconbutn = grid.FindComponent<MudIconButton>();

            Assert.NotNull(grid);
            Assert.Equal(Justify.FlexStart, grid.Instance.Justify);
            Assert.Equal(2, grid.Instance.Spacing);

            Assert.NotNull(iconbutn);
            Assert.Equal(Icons.Material.Filled.ArrowBack, iconbutn.Instance.Icon);
        }

        [Fact]
        public void Name_Text()
        {
            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var mudtext = comp.FindComponents<MudText>()[0];

            Assert.NotNull(mudtext);
            Assert.Equal("pa-2", mudtext.Instance.Class);
            Assert.Equal(Align.Center, mudtext.Instance.Align);
            Assert.Equal(Typo.h6, mudtext.Instance.Typo);

        }

        [Fact]
        public void Test_Paper_Fields()
        {
            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var paper = comp.FindComponents<MudPaper>()[0];
            var field1 = comp.FindComponents<MudTextField<string>>()[0];
            //var field2 = comp.FindComponents<MudTextField<string>>()[1];


            Assert.Equal("d-flex align-items-center justify-space-between pa-0 ma-0", paper.Instance.Class);
            Assert.Equal(0, paper.Instance.Elevation);

            Assert.NotNull(field1);
            Assert.Equal(Variant.Text, field1.Instance.Variant);

            //Assert.Equal("name_ua", field1.Instance.Value);
            //Assert.Equal("font-size:smaller", field1.Instance.Style);
            Assert.True(field1.Instance.DisableUnderLine);


            //Assert.NotNull(field2);
            //Assert.Equal(Variant.Text, field2.Instance.Variant);
            //Assert.Equal("text-align:right !important", field2.Instance.Style);
            //Assert.True(field2.Instance.DisableUnderLine);
        }

        [Fact]
        public void Test_Paper_Fields2()
        {

            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var paper = comp.FindComponents<MudPaper>()[1];
            var field1 = comp.FindComponents<MudTextField<string>>()[2];
            //var field2 = comp.FindComponents<MudTextField<string>>()[3];


            Assert.Equal("d-flex align-items-center justify-space-between pa-0 ma-0", paper.Instance.Class);
            Assert.Equal(0, paper.Instance.Elevation);

            Assert.NotNull(field1);
            Assert.Equal(Variant.Text, field1.Instance.Variant);
            //Assert.Equal("name_ua", field1.Instance.Value);
            //Assert.Equal("font-size:smaller", field1.Instance.Style);
            Assert.True(field1.Instance.DisableUnderLine);


            //Assert.NotNull(field2);
            //Assert.Equal(Variant.Text, field2.Instance.Variant);
            //Assert.Equal("text-align:right !important", field2.Instance.Style);
            //Assert.True(field2.Instance.DisableUnderLine);

        }

        [Fact]
        public async  void Test_ProfilesetText()
        {

            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");

            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var mudtext = comp.FindComponents<MudText>()[1];

            Assert.NotNull(mudtext);
            Assert.Equal("mud-text pl-2", mudtext.Instance.Class);
            Assert.Equal(Typo.caption, mudtext.Instance.Typo);
            Assert.Equal(Align.Left, mudtext.Instance.Align);
            mudtext.MarkupMatches("<span class=\"mud-typography mud-typography-caption mud-typography-align-left mud-text pl-2\">Profile Settings</span>");
        }

        [Fact]
        public void Test_Paper_Text()
        {
            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var paper = comp.FindComponents<MudPaper>()[2];
            var text = comp.FindComponents<MudText>()[2];

            Assert.NotNull(paper);
            Assert.Equal("d-flex align-items-center justify-space-between border rounded-0 pa-0 ma-0", paper.Instance.Class);
            Assert.Equal(0, paper.Instance.Elevation);

            Assert.NotNull(text);
            Assert.Equal("mud-text pl-2", text.Instance.Class);
            Assert.Equal(Typo.h6, text.Instance.Typo);
        }

        [Fact]
        public async void Button_CreateProfile()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");

            Mydevicemethod2();
            var comp = RenderComponent<CreateProfile>();
            var button = comp.FindComponent<MudButton>();

            Assert.NotNull(button);
            Assert.Equal("text-transform:none;", button.Instance.Style);
            Assert.Equal(Variant.Filled, button.Instance.Variant);
            Assert.True(button.Instance.FullWidth);
            Assert.Equal(Color.Primary, button.Instance.Color);
            Assert.Equal("ml-auto", button.Instance.Class);
            button.Find("span").MarkupMatches("<span class=\"mud-button-label\">Create a Profile</span>");

        }






    }
}
