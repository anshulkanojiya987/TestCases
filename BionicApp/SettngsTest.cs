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
//    public class SettngsTest : LoginLogoutTest
//    {
        
        
//        [Fact]

//        public void Check_preferences_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Preferences";
//            string Key1 = "preferences_ua";
//            string defaultValue1 = "Preferences";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_preferences_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Einstellungen";
//            string Key1 = "preferences_ua";
//            string defaultValue1 = "Preferences";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

        
//        [Fact]

//        public void Check_operations_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Operations";
//            string Key2 = "operations_ua";
//            string defaultValue2 = "Operations";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_operations_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string Key2 = "operations_ua";
//            string defaultValue2 = "Operations";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            string ExpectedString = "Operationen";
//            Assert.Equal(translatedText, ExpectedString);
//        }
//    }
//}
