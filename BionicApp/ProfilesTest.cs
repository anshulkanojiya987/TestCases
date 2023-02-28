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
//    public class ProfilesTest : LoginLogoutTest
//    {
       
      
//        [Fact]

//        public void Check_myprofiles_uaa_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "My Profiles";
//            string Key1 = "myprofiles_ua";
//            string defaultValue1 = "My Profiles";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_myprofiles_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Meine Profile";
//            string Key1 = "myprofiles_ua";
//            string defaultValue1 = "My Profiles";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

        
//        [Fact]

//        public void Check_createprofile_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Create a Profile";
//            string Key2 = "createprofile_ua";
//            string defaultValue2 = "Create a Profile";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_createprofile_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string Key2 = "createprofile_ua";
//            string defaultValue2 = "Create a Profile";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            string ExpectedString = "Erstelle ein Profil";
//            Assert.Equal(translatedText, ExpectedString);
//        }
//    }
//}
