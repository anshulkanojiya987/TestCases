using BionicApp.Pages.Add_Device.My_Devices;
using Bunit;
using MudBlazor;
using Ossur.Bionics.Common;
using System.Globalization;
using Xunit;

namespace BionicAppTestRunner.BionicAppUi
{
    public class StepCountTest : BionicAppUiTestBase
    {

        [Fact]
        public void MudStack1_Test()
        {
            Mydevicemethod2();
            var comp = RenderComponent<StepCount>();
            var stack = comp.FindComponents<MudStack>()[0];

            Assert.Equal("pa-4", stack.Instance.Class);
            Assert.NotNull(stack);
        }

        [Fact]
        public void GridAnd_Icon()
        {
            Mydevicemethod2();
            var comp = RenderComponent<StepCount>();
            var grid = comp.FindComponents<MudGrid>()[0];
            var iconbutn = grid.FindComponents<MudIconButton>()[0];

            Assert.NotNull(grid);
            Assert.Equal(Justify.SpaceBetween, grid.Instance.Justify);
            Assert.Equal(2, grid.Instance.Spacing);

            Assert.NotNull(iconbutn);
            Assert.Equal(Icons.Material.Filled.ArrowBack, iconbutn.Instance.Icon);
        }

        [Fact]
        public async void Text_Header()
        {

            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");

            const string key = "TranslationCutoffDate";

            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");

            Mydevicemethod2();
            var comp = RenderComponent<StepCount>();
            var text = comp.FindComponents<MudText>()[0];

            Assert.NotNull(text);
            Assert.Equal(Align.Center, text.Instance.Align);
            Assert.Equal(Typo.h6, text.Instance.Typo);
            text.Find("b").MarkupMatches("<b>Step Count</b>");
        }

        [Fact]
        public void Test_closebutton()
        {
            Mydevicemethod2();
            var comp = RenderComponent<StepCount>();
            var iconbutn = comp.FindComponents<MudIconButton>()[1];

            Assert.NotNull(iconbutn);
            Assert.Equal(Icons.Material.Filled.Close, iconbutn.Instance.Icon);
        }

        [Fact]
        public void Test_Chart()
        {
            Mydevicemethod2();
            var comp = RenderComponent<StepCount>();
            var paper = comp.FindComponents<MudPaper>()[1];
            var chart = paper.FindComponent<MudChart>();

            Assert.NotNull(chart);
            Assert.Equal(ChartType.Bar, chart.Instance.ChartType);
            Assert.Equal("100%", chart.Instance.Width);
            Assert.Equal("250px", chart.Instance.Height);

            var labels = chart.Instance.XAxisLabels;
            Assert.NotNull(labels);
            Assert.Equal(31, labels.Length);
            //Assert.Equal(ChartSeries.);
        }

        [Fact]
        public void CheckDisplayName()
        {
            Mydevicemethod2();
            var component = RenderComponent<StepCount>();
            var mudtext = component.FindComponents<MudText>()[1];
            Assert.Equal(Typo.subtitle1, mudtext.Instance.Typo);
            mudtext.Find("b").MarkupMatches("<b>390775</b>");
        }
        [Fact]
        public void CheckModelName()
        {
            Mydevicemethod2();
            var component = RenderComponent<StepCount>();
            var mudtext = component.FindComponents<MudText>()[2];
            Assert.Equal(Typo.caption, mudtext.Instance.Typo);
            mudtext.MarkupMatches("<span class=\"mud-typography mud-typography-caption\">PROPRIO_FOOT</span>");
        }
        [Fact]
        public void CheckstepCountText()
        {
            Mydevicemethod2();
            var component = RenderComponent<StepCount>();
            var mudpaper = component.FindComponent<MudPaper>();
            Assert.Equal("mx-auto pa-12 rounded-circle", mudpaper.Instance.Class);
            Assert.Equal("background-color: #D9D9D9;", mudpaper.Instance.Style);
            var mudtext = mudpaper.FindComponent<MudText>();
            Assert.Equal(Typo.body1, mudtext.Instance.Typo);
            mudtext.MarkupMatches("<p class=\"mud-typography mud-typography-body1\">0</p>");
        }

    }
}
