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
//    public class AnkleAlignmentTest : LoginLogoutTest
//    {
        
//        [Fact]

//        public void Check_anklealignment_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Ankle Alignment";
//            string Key1 = "anklealignment_ua";
//            string defaultValue1 = "Ankle Alignment";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_anklealignment_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Knöchelausrichtung";
//            string Key1 = "anklealignment_ua";
//            string defaultValue1 = "Ankle Alignment";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

        
//        [Fact]

//        public void Check_manual_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Manual";
//            string Key2 = "manual_ua";
//            string defaultValue2 = "Manual";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_manual_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string Key2 = "manual_ua";
//            string defaultValue2 = "Manual";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            string ExpectedString = "Handbuch";
//            Assert.Equal(translatedText, ExpectedString);
//        }
//    }
//}
