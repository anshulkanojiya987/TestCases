﻿using BionicApp.Pages.Add_Device;
using Bunit;
using MudBlazor;
using Ossur.Bionics.Common;
using System.Globalization;
using Xunit;

namespace BionicAppTestRunner.BionicAppUi
{
    public class DashboardTest : BionicAppUiTestBase
    {
        [Fact]
        public void Tabs_DisplayTest()
        {
            var component = RenderComponent<MudTabs>(parameters => parameters
            .Add(p => p.Class, "tabContent")
            );
            var actualName = component.Find(".tabContent");
            Assert.NotNull(actualName);

        }

        [Fact]
        public void Test_tabPanelCount()
        {
            var comp = RenderComponent<Dashboard>();
            var mudtab = comp.FindComponent<MudTabs>();
            var panelcount = mudtab.Instance.Panels.Count();
            Assert.Equal(3, panelcount);
        }

        [Fact]
        public async void UserPanel_Properties()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");

            var component = RenderComponent<Dashboard>();
            var mudtab = component.FindComponent<MudTabs>();
            var activepanel = mudtab.Instance.ActivePanel;

            var aptext = activepanel.Text;
            Assert.NotNull(activepanel);
            Assert.Equal("User", aptext);

            var icon = mudtab.Instance.ActivePanel.Icon;
            Assert.NotNull(activepanel);
            Assert.Equal(Icons.Material.Filled.Person, icon);


            Assert.NotNull(activepanel.Style);
            Assert.Equal("text-transform:none;", activepanel.Style);
        }

        [Fact]
        public async void Mydevicespanel_properties()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");

            var component = RenderComponent<Dashboard>();
            var mudtab = component.FindComponent<MudTabs>();
            var adpanel = mudtab.Instance.Panels[1];

            var adptext = adpanel.Text;
            Assert.NotNull(adptext);
            Assert.Equal("My Devices", adptext);

            var icon = adpanel.Icon;
            Assert.NotNull(icon);
            Assert.Equal(Icons.Material.Filled.FormatListBulleted, icon);

            Assert.NotNull(adpanel.Style);
            Assert.Equal("text-transform:none;", adpanel.Style);
        }

        [Fact]
        public async void Infopanel_properties()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<Dashboard>();
            var mudtab = component.FindComponent<MudTabs>();
            var infopanel = mudtab.Instance.Panels[2];

            var infotext = infopanel.Text;
            Assert.NotNull(infotext);
            Assert.Equal("Info", infotext);

            var icon = infopanel.Icon;
            Assert.NotNull(icon);
            Assert.Equal(Icons.Material.Filled.Info, icon);

            Assert.NotNull(infopanel.Style);
            Assert.Equal("text-transform:none;", infopanel.Style);
            Assert.NotNull(infopanel.Tag);
        }

        [Fact]
        public async Task TabsSwitching()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");

            var comp = RenderComponent<Dashboard>();
            var mudTabs = comp.FindComponent<MudTabs>().Instance;

            // Act on tab 1
            var firstTab = mudTabs.Panels[0];
            firstTab.OnClick.InvokeAsync(null);
            await Task.Delay(1000); // waiting for MudTabs animation to complete
            var firstTabPanel = mudTabs.ActivePanel;
            Assert.Equal("User", firstTabPanel.Text);

            // Act on tab 2
            await comp.InvokeAsync(() => mudTabs.ActivatePanel(1));
            await Task.Delay(1000); // waiting for MudTabs animation to complete
            var secondTabPanel = mudTabs.ActivePanel;
            Assert.Equal("My Devices", secondTabPanel.Text);


            //Act on tab 3
            await comp.InvokeAsync(() => mudTabs.ActivatePanel(2));
            await Task.Delay(1000);
            var thirdTabPanel = mudTabs.ActivePanel;
            Assert.Equal("Info", thirdTabPanel.Text);

        }

        [Fact]
        public void Test_TabViewHeight()
        {
            var comp = RenderComponent<Dashboard>();
            var mtab = comp.FindComponent<MudTabs>();

            var expectedHeight = 800;
            mtab.Instance.MaxHeight = expectedHeight;

            comp.WaitForAssertion(() =>
            {
                var tabContentElements = mtab.FindAll("div.mud-tab-panels");
                foreach (var element in tabContentElements)
                {
                    Assert.Equal($"{expectedHeight}px", element.GetAttribute("style").Split(';').FirstOrDefault(s => s.Contains("max-height"))?.Split(':')[1]?.Trim());
                    //getattribute to get styles -split method to split style attribute value into array of individual styles - firstordefault -to first style decoration contains maxheight - if exists - split into property name and value seperated by : -finally trim removing whitespaces from property value--- then compare with maxheight
                }
            });
        }

        //[Fact]
        //public void Test_KeepPanelProperty()
        //{
        //    var comp = RenderComponent<Dashboard>();
        //    var mudtab = comp.FindComponent<MudTabs>().Instance;

        //    //Act-panels-null at false
        //    mudtab.KeepPanelsAlive = false;
        //    var panels = mudtab.Panels;
        //    foreach (var panel in panels)
        //    {
        //        Assert.Null(panel.TabContent);
        //    }

        //    // Act-panels-notnull at true
        //    mudtab.KeepPanelsAlive = true;
        //    panels = mudtab.Panels;
        //    foreach (var panel in panels)
        //    {
        //        Assert.NotNull(panel.TabContent);
        //    }
        //}

        [Fact]
        public void MudTab_Properties()
        {
            var comp = RenderComponent<Dashboard>();
            var mudtab = comp.FindComponent<MudTabs>().Instance;

            Assert.Equal(Position.Bottom, mudtab.Position);
            Assert.Equal("100%", mudtab.MinimumTabWidth);
            Assert.True(mudtab.KeepPanelsAlive);
            Assert.Equal("tabContent", mudtab.Class);
            Assert.False(mudtab.Border);
            Assert.True(mudtab.Centered);
            Assert.False(mudtab.Outlined);
            Assert.False(mudtab.AlwaysShowScrollButtons);
        }

        [Fact]
        public void Test_MudPaper()
        {
            var comp = RenderComponent<Dashboard>();
            var paper = comp.FindComponent<MudPaper>();

            Assert.Equal("100%", paper.Instance.Width);
            Assert.False(paper.Instance.Outlined);
            Assert.Equal(0, paper.Instance.Elevation);
            Assert.Equal("wrapperContent", paper.Instance.Class);
        }

        [Fact]
        public void Test_MudStack()
        {
            var comp = RenderComponent<Dashboard>();
            var stack = comp.FindComponent<MudStack>();
            Assert.Equal(3, stack.Instance.Spacing);
        }

    }
}

