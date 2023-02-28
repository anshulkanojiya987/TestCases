//using Ossur.Bionics.Common;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace BionicAppTestRunner.BionicApp
//{
//    public class CreateProfileTest : LoginLogoutTest
//    {
        
       
//        [Fact]

//        public void Check_details_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Details";
//            string Key1 = "details_ua";
//            string defaultValue1 = "Details";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_details_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Einzelheiten";
//            string Key1 = "details_ua";
//            string defaultValue1 = "Details";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

       
//        [Fact]

//        public void Check_profilesettings_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Profile Settings";
//            string Key2 = "profilesettings_ua";
//            string defaultValue2 = "Profile Settings";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_profilesettings_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string Key2 = "profilesettings_ua";
//            string defaultValue2 = "Profile Settings";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            string ExpectedString = "Profileinstellungen";
//            Assert.Equal(translatedText, ExpectedString);
//        }
//    }
//}
