using BionicApp.Pages.Add_Device.Steps;
using Bunit;
using MudBlazor;
using Ossur.Bionics.Common;
using System.Globalization;
using Xunit;

namespace BionicAppTestRunner.BionicAppUi
{
    public class Step2Ui : BionicAppUiTestBase
    {
        [Fact]
        public async void checkMudDialog()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<Step2>();
            var mudDialog = component.FindComponents<MudDialog>()[0];
            Assert.Equal("ma-6", mudDialog.Instance.Class);
            Assert.True(mudDialog.Instance.IsVisible);
            //IBluetoothLE.IsAvailable
        }
        [Fact]
        public async void check1stDialogContent()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<Step2>();
            var mudDialog = component.FindComponents<MudDialog>()[0];
            Assert.Equal("enablebluetooth_ua", (mudDialog.Instance.DialogContent).ToString());
            //var DialogItem = mudDialog.FindComponent<DialogContent>();
            mudDialog.MarkupMatches("");
        }
        [Fact]
        public void checkMudGrid()
        {
            var component = RenderComponent<Step2>();
            var mudGrid = component.FindComponents<MudGrid>()[0];
            Assert.Equal(2,mudGrid.Instance.Spacing);
            Assert.Equal(Justify.FlexStart, mudGrid.Instance.Justify);
        }
        [Fact]
        public void check1stMudItemInMudGrid()
        {
            var component = RenderComponent<Step2>();
            var mudGrid = component.FindComponents<MudGrid>()[0];
            var mudTtem = mudGrid.FindComponents<MudItem>()[0];
            var MudIconButton = mudTtem.FindComponent<MudIconButton>();
            Assert.Equal("<path d=\"M0 0h24v24H0z\" fill=\"none\"/><path d=\"M20 11H7.83l5.59-5.59L12 4l-8 8 8 8 1.41-1.41L7.83 13H20v-2z\"/>", MudIconButton.Instance.Icon);
            
        }
        [Fact]
        public async void checkMudTextInMudGrid()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<Step2>();
            var mudGrid = component.FindComponents<MudGrid>()[0];
            var mudTtem = mudGrid.FindComponents<MudItem>()[1];
            var mudText = mudTtem.FindComponent<MudText>();
            Assert.Equal(Typo.h5, mudText.Instance.Typo);
            Assert.Equal(Align.Center, mudText.Instance.Align);
            mudText.MarkupMatches("<h5 class=\"mud-typography mud-typography-h5 mud-typography-alingn-center\">Add a device</h5>");
        }
        [Fact]
        public async void CheckStepText()
        {
            var manager =await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            var cloud = await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<Step2>();
            var mudText = component.FindComponents<MudText>()[1];
            Assert.Equal(Typo.subtitle1,mudText.Instance.Typo);
            mudText.MarkupMatches("<h6 class=\"mud-typography mud-typography-subtitle1\">Step 2/4</h6>");
        }
        [Fact]
        public void checkrefreshButton() 
        {
            var component = RenderComponent<Step2>();
            var MudIconButton = component.FindComponents<MudIconButton>()[1];
            Assert.Equal("refresh", MudIconButton.Instance.Class);
            var MudProgessCircu= MudIconButton.FindComponent<MudProgressCircular>();
            Assert.Equal("ms-n1",MudProgessCircu.Instance.Class);
            Assert.Equal(MudBlazor.Size.Small, MudProgessCircu.Instance.Size);
            Assert.True(MudProgessCircu.Instance.Indeterminate);
            //var MudIcon = MudIconButton.FindComponent<MudIcon>();
            //Assert.Equal("< path d =\"M0 0h24v24H0z\" fill=\"none\"/><path d=\"M17.65 6.35C16.2 4.9 14.21 4 12 4c-4.42 0-7.99 3.58-7.99 8s3.57 8 7.99 8c3.73 0 6.84-2.55 7.73-6h-2.08c-.82 2.33-3.04 4-5.65 4-3.31 0-6-2.69-6-6s2.69-6 6-6c1.66 0 3.14.69 4.22 1.78L13 11h7V4l-2.35 2.35z\"/>", MudIcon.Instance.Icon);
        }

    }
}
