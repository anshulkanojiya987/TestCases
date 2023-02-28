using Moq;
using Ossur.Bionics.Common;
using Ossur.Bionics.Common.Maui.Services;
using Ossur.Bionics.Common.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BionicAppTestRunner.BionicApp
{
    
    public class InfoTest : LoginLogoutTest
    {
        
        [Fact]
        public void Version_IsInCrtFrmt()
        {
            // Arrange
            var version = AppInfo.Current.VersionString;

            // Act & Assert
            Assert.Matches(@"^\d+(\.\d+)+$", version);
        }

        [Fact]
        public void Version_IsNotNull()
        {
            // Arrange
            var version = AppInfo.Current.VersionString;

            // Act
            var versionObject = new Version(version);

            // Assert
            Assert.NotNull(versionObject);
        }

        [Fact]
        public void ExptdVersion()
        {
            // Arrange
            var expectedVersion = AppInfo.Current.VersionString;

            // Act
            var actualVersion = AppInfo.Current.VersionString;

            // Assert
            Assert.Equal(expectedVersion, actualVersion);
        }
        [Fact]
        public void ExpectedClientType()
        {
            // Arrange
            var expectedClientType = "Android";
           
            var manager = Manager.Instance;

            // Act
            var clientType = manager.CurrentClient.Type;

            // Assert
            Assert.Equal(expectedClientType, clientType);
        }
        //[Theory]
        //[InlineData("2022-01-01 12:00:00")]
        //[InlineData("2022-12-31 23:59:59")]
        //public void PublishDate_RtrnExptdValue(string expectedDate)
        //{
        //    // Arrange
        //    //DateTime expectedPublishDate = DateTime.Parse(expectedDate);
        //    //var actualPublishDate = Helper.GetBuildDate();

        //    // Act & Assert
        //    //Assert.Equal(expectedPublishDate, actualPublishDate);
        //    //Assert.True(false);
        //}

        
        //[Fact]

        //public void Check_publishdate_ua_English_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "publishdate_ua";
        //    string defaultValue1 = "Publish date";
        //    string ExpectedString = "Publish date";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_publishdate_ua_German_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Erscheinungsdatum";
        //    string Key1 = "publishdate_ua";
        //    string defaultValue1 = "Publish date";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        
        //[Fact]

        //public void Check_termsofusa_ua_English_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Terms of Use Agreement";
        //    string Key2 = "termsofusa_ua";
        //    string defaultValue2 = "Terms of Use Agreement";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_termsofusa_ua_German_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "termsofusa_ua";
        //    string defaultValue2 = "Terms of Use Agreement";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Nutzungsbedingungen Vereinbarung";
        //    Assert.Equal(translatedText, ExpectedString);
        //}
    }
}
