
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
    public class LoginTest : LoginLogoutTest
    {
        
        [Fact]
        //1. To check whether current user is intialized correctly
        public void CurrentUser_IsCorrectlyInitialized()
        {
            CloudLogin();
            var manager = Manager.Instance;

            Assert.NotNull(manager.CurrentUser);

        }

        [Fact]
        //2.checking whether a locallogin is correctly initialized or not
        public void LocalLoginIsCorrectlyInitialized()
        {
            CloudLogin();
            var manager = Manager.Instance;

            try
            {
                Assert.False(manager.LocalLogin);

            }
            catch (Exception ex)
            {
                Assert.True(false, $"Error:{ex.Message}");

            }
        }

        [Fact]
        //3
        public async void LocalLogin_RtrnsExpctd()
        {
            await Manager.Instance.Login("tst_admin@example.com", "tst_admin_42");
            // Arrange
            bool localLogin = Manager.Instance.LocalLogin;
           
            // Assert
            Assert.True(localLogin);
        }


        [Fact]
        //4.checking for invalid input returns false
        public async void Login_InvalidInput_ReturnFalse()
        {
            // Arrange
            var manager = Manager.Instance;

            // Act
            var result = await manager.Login("valid_endpoint", "invalid_email", "invalid_password");

            // Assert
            Assert.False(result);
        }


        [Fact]
        //5.invalid email in CanLoginToLocalhost
        public void CanLoginToLocalhost_InvalidEmail_ReturnFalse()
        {
            // Arrange
            var manager = Manager.Instance;

            // Act
            var result = manager.CanLoginToLocalhost("invalid_email");

            // Assert
            Assert.False(result);
        }

        [Fact]
        //6.checking whether current user is not null after logging in
        public void CurrentUser_Is_Not_Null_After_Login()
        {
            try
            {
                CloudLogin();
                Assert.NotNull(Manager.Instance.CurrentUser);
            }
            catch
            {
                Assert.False(true);
            }
        }

        [Fact]
        //7.current user email is not empty
        public void CurrentUserEmailIsNotEmpty()
        {
            CloudLogin();
            var User = Manager.Instance;
            // Assert
            var currentUser = Manager.Instance.CurrentUser;
            Assert.NotNull(currentUser);
            Assert.NotEmpty(currentUser.Email);
            Assert.True(User.IsLoggedIn());
        }


        [Fact]
        //8.current user firstname is not empty
        public void CurrentUser_Firstname_IsNotEmpty()
        {
            var manager = Manager.Instance;
            var email = Manager.Instance.GetValue("last_user", "");
            var password = Manager.Instance.GetValue("last_password", "");
            manager.Login(email, password).Wait();
            var firstName = manager.CurrentUser.First;
            Assert.True(!string.IsNullOrEmpty(firstName));
        }

        [Fact]
        //9.current user lastname is not empty
        public void CurrentUser_LastName_IsNotEmpty()
        {
            var manager = Manager.Instance;
            var email = Manager.Instance.GetValue("last_user", "");
            var password = Manager.Instance.GetValue("last-password", "");
            manager.Login(email, password).Wait();
            var lastName = manager.CurrentUser.Last;
            Assert.True(!string.IsNullOrEmpty(lastName));
        }

        [Fact]
        //10.current user is null after logout
        public async void CurrentUserIsNull_AfterLogout()
        {
            // Arrange
            var manager = Manager.Instance;
            var user = Manager.Instance.GetValue("lastuser", "");
            var password = Manager.Instance.GetValue("lastpassword", "");
            await manager.Login(user, password);

            // Act
            manager.Logout();

            // Assert
            Assert.Null(manager.CurrentUser);
            Assert.False(manager.IsLoggedIn());
        }

        [Fact]
        //11. credentials are null after logout
        public async void CurrentUser_AllCredentials_NullOrEmpty_Logout()
        {
            Manager manager = Manager.Instance;
            var user = Manager.Instance.GetValue("lastuser", "");
            var password = Manager.Instance.GetValue("lastpassword", "");
            await manager.Login(user, password);

            //Asserts for the currentUser's properties before logout
            Assert.NotNull(manager.CurrentUser?.Email);
            Assert.NotNull(manager.CurrentUser?.First);
            Assert.NotNull(manager.CurrentUser?.Last);

            manager.Logout();

            //Asserts for the currentUser's properties after logout
            Assert.True(string.IsNullOrEmpty(manager.CurrentUser?.Email));
            Assert.True(string.IsNullOrEmpty(manager.CurrentUser?.First));
            Assert.True(string.IsNullOrEmpty(manager.CurrentUser?.Last));
        }

        [Fact]
        //12
        public void LoggedIn_ReturnsExpected()
        {
            // Arrange
            CloudLogin();
            var user = Manager.Instance;

            // Act & Assert: Check that IsLoggedIn returns true when user is logged in
            Assert.True(user.IsLoggedIn());

            // Act
            user.Logout();

            // Assert: Check that IsLoggedIn returns false when user is not logged in
            Assert.False(user.IsLoggedIn());
        }
        
        //[Fact]

        //public void Check_welcometextheader_ua_English_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Welcome to the Össur Logic app! ";
        //    string Key1 = "welcometextheader_ua";
        //    string defaultValue1 = "Welcome to the Össur Logic app! ";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_welcometextheader_ua_German_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "Willkommen bei der Össur Logic-App!";
        //    string Key1 = "welcometextheader_ua";
        //    string defaultValue1 = "Welcome to the Össur Logic app! ";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key1, cultureInfo.Name, defaultValue1);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        
        //[Fact]

        //public void Check_userguidetext_ua_English_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string ExpectedString = "User Guide";
        //    string Key2 = "userguidetext_ua";
        //    string defaultValue2 = "User Guide";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    Assert.Equal(translatedText, ExpectedString);
        //}

        //[Fact]
        //public void Check_userguidetext_ua_German_Localization()
        //{
        //    CloudLogin();
        //    GetTranslationTerm();
        //    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
        //    var cultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
        //    string Key2 = "userguidetext_ua";
        //    string defaultValue2 = "User Guide";
        //    string translatedText = Manager.Instance.GetLocalizedString(Key2, cultureInfo.Name, defaultValue2);
        //    string ExpectedString = "Benutzerhandbuch";
        //    Assert.Equal(translatedText, ExpectedString);
        //}
    }
}
