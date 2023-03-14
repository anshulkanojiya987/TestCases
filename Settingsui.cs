using AngleSharp.Css.Values;
using BionicApp.Pages.Add_Device.My_Devices.DeviceSettings;
using Bunit;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BionicAppTestRunner.BionicAppUi
{
    public class Settingsui : BionicAppUiTestBase
    {
        [Fact]
        public void checkmainStack()
        {
            var Component = RenderComponent<Settings>();
            var mudStack = Component.FindComponent<MudStack>();
            Assert.Equal(2, mudStack.Instance.Spacing);
            Assert.Equal("pa-4",mudStack.Instance.Class);
            Assert.False(mudStack.Instance.Row);
        }
        [Fact]
        public void checkMudGrid()
        {
            var Component = RenderComponent<Settings>();
            var mudStack = Component.FindComponent<MudStack>();
            var mudGrid = mudStack.FindComponent<MudGrid>();
            Assert.Equal(2, mudGrid.Instance.Spacing);
            Assert.Equal(Justify.FlexStart, mudGrid.Instance.Justify);
        }
        [Fact]
        public void check1stMudItemInMudGrid()
        {
            mydevicemethod();
            var Component = RenderComponent<Settings>();
            var mudStack = Component.FindComponent<MudStack>();
            var mudGrid = mudStack.FindComponent<MudGrid>();
            var mudItem = mudGrid.FindComponent<MudItem>();
            var MudIconBut = mudItem.FindComponent<MudIconButton>();
            Assert.Equal("< path d =\"M0 0h24v24H0z\" fill=\"none\"/><path d=\"M20 11H7.83l5.59-5.59L12 4l-8 8 8 8 1.41-1.41L7.83 13H20v-2z\"/>", MudIconBut.Instance.Icon);
            var nav =MudIconBut.Services.GetRequiredService<NavigationManager>();
            Assert.Equal("http://localhost/", nav.Uri);
        }

    }
}
