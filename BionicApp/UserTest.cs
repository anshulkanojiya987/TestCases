using Ossur.Bionics.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BionicAppTestRunner.BionicApp
{
    public class UserTest : LoginLogoutTest
    {
      
        
        [Fact]
        public void Check_User_NotNull()
        {
            CloudLogin();
            var manager = Manager.Instance.CurrentUser;
            Assert.NotNull(manager);
        }
        [Fact]
        public void Check_FullName()
        {
            CloudLogin();
            Manager manager = Manager.Instance;

            Assert.NotNull(manager.CurrentUser?.FullName);
        }

        [Fact]
        public void Check_Email()
        {
            CloudLogin();
            Manager manager = Manager.Instance;
            Assert.NotNull(manager.CurrentUser?.Email);
        }

        [Fact]
        public void Check_UserRoles()
        {
            CloudLogin();
            Manager manager = Manager.Instance;
            Assert.NotNull(manager.CurrentUser?.UserRoles);
        }
        
        [Fact]
        public void Check_CountOf_language()
        {
            CloudLogin();
            GetTranslationTerm();
            var languages = Manager.Instance.GetSupportedLanguages();
            var lanCount = languages.Count;
            int ExpectedCount = 18;
            Assert.Equal(ExpectedCount, lanCount);
        }


        [Fact]

        public void Check_name_ua_English_Localization()
        {

            CloudLogin();
            GetTranslationTerm();
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
            string ExpectedString = "Name";
            string Key1 = "name_ua";
            string defaultValue1 = "Name";
            string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
            Assert.Equal(translatedText, ExpectedString);
        }

        //[Fact]
        //public void Check_name_ua_Chinese_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("zh");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "姓名";
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Czech_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("cs");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "název";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Danish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("da");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Navn";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Dutch_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("nl");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Naam";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Finnish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fi");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Nimi";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_French_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Nom";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_German_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Name";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Greek_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("el");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Ονομα";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Icelandic_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("is");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Nafn";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Italian_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("it");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Nome";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Japanese_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ja");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "名前";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Korean_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ko");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "이름";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Norwegian_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("no");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Navn";
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Portuguese_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Nome";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Russian_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ru");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Имя";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Spanish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "Nombre";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Swedish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("sv");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "namn";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_name_ua_Turkish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("tr");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key1 = "name_ua";
        //    string defaultValue1 = "Name";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    string ExpectedString = "vİsim";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]

        //public void Check_settings_preferences_English_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Settings and preferences";
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Chinese_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("zh");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "设置和首选项";
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Czech_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("cs");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Nastavení a předvolby";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Danish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("da");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Indstillinger og præferencer";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Dutch_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("nl");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Instellingen en voorkeuren";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Finnish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fi");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Asetukset ja asetukset";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_French_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Paramètres et préférences";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_German_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Einstellungen und Präferenzen";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Greek_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("el");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Ρυθμίσεις και προτιμήσεις";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Icelandic_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("is");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Stillingar og óskir";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Italian_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("it");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Impostazioni e preferenze";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Japanese_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ja");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "設定と設定";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Korean_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ko");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "설정 및 기본 설정";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Norwegian_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("no");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Innstillinger og preferanser";
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Portuguese_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Configurações e preferências";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Russian_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ru");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Настройки и предпочтения";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Spanish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Configuraciones y preferencias";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Swedish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("sv");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Configuraciones y preferencias";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_settings_preferences_Turkish_Localization()
        //{
        //    loginLogoutTest.CloudLogin();
        //    loginLogoutTest.GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("tr");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "settings_preferences";
        //    string defaultValue2 = "Settings and preferences";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Ayarlar ve tercihler";
        //    Assert.Equal(translatedText, ExpectedString);
        //}

    }


}
    

