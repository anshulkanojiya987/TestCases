using BionicApp.Pages.Add_Device.Steps;
using Bunit;
using MudBlazor;
using Ossur.Bionics.Common;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //var DialogAction = mudDialog.FindComponent<DialogActions>();
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
            Assert.Equal("@Icons.Material.Filled.ArrowBack", MudIconButton.Instance.Icon);
            
        }
    }
}
