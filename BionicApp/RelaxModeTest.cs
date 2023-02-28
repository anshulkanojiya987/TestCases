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
//    public class RelaxModeTest : LoginLogoutTest
//    {
        
        
//        [Fact]

//        public void Check_relaxmode_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Relax Mode";
//            string Key1 = "relaxmode_ua";
//            string defaultValue1 = "Relax Mode";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_relaxmode_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string ExpectedString = "Relax-Modus";
//            string Key1 = "relaxmode_ua";
//            string defaultValue1 = "Relax Mode";
//            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
//            Assert.Equal(translatedText, ExpectedString);
//        }

        
//        [Fact]

//        public void Check_relaxmode_description_ua_English_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string Key2 = "relaxmode_description_ua";
//            string defaultValue2 = "Description text, max 6 lines if more trunctuate the text. Relax mode lorem ipsum. Description text, max 6 lines if more trunctuate the text. Relax mode lorem ipsum. Description text, max 6  ... more";
//            string ExpectedString = "Description text, max 6 lines if more trunctuate the text. Relax mode lorem ipsum. Description text, max 6 lines if more trunctuate the text. Relax mode lorem ipsum. Description text, max 6  ... more";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            Assert.Equal(translatedText, ExpectedString);
//        }

//        [Fact]
//        public void Check_relaxmode_description_ua_German_Localization()
//        {
//            CloudLogin();
//            GetTranslationTerm();
//            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
//            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
//            string Key2 = "relaxmode_description_ua";
//            string defaultValue2 = "Description text, max 6 lines if more trunctuate the text. Relax mode lorem ipsum. Description text, max 6 lines if more trunctuate the text. Relax mode lorem ipsum. Description text, max 6  ... more";
//            string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
//            string ExpectedString = "Beschreibungstext, max. 6 Zeilen, wenn mehr den Text abschneiden. Entspannungsmodus lorem ipsum. Beschreibungstext, max. 6 Zeilen, wenn mehr den Text abschneiden. Entspannungsmodus lorem ipsum. Beschreibungstext, max 6 ... mehr";
//            Assert.Equal(translatedText, ExpectedString);
//        }
//    }
//}
