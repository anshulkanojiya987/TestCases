using BionicApp.Pages.Add_Device;
using BionicAppTestRunner.BionicApp;
using Bunit;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MudBlazor;
using Ossur.Bionics.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static MudBlazor.CategoryTypes;
using static MudBlazor.FilterOperator;

namespace BionicAppTestRunner.BionicAppUi
{
    public class UserUI : BionicAppUiTestBase 
    {
        [Fact]
        public async void CheckLogo()
        {
            await Manager.Instance.Login("tst_admin@example.com", "tst_admin_42");
            var component = RenderComponent<User>();
            var avtar = component.FindComponent<MudAvatar>();
         //   Assert.NotNull(avtar);
        }


        [Fact]
        public void checkText()
        {
            var name = RenderComponent<MudField>(p => p.Add(x => x.Label, "Name"));
            
        }

        [Fact]
        public void check_Logout_Button() 
        {
            // Arrange
            var LogoutButton = RenderComponent<MudButton>(p => p
                .Add(x => x.Style," height:52px; text-transform:none;")
            );
            
        }

        [Fact]
        public void check_Languages()
        {
            var component = RenderComponent<User>();
            var languages = component.FindComponent<MudSelect<SelectionMode>>();
            var lancount = languages.RenderCount;
            Assert.Equal(18, lancount);
        }
        
        
        //[Fact]
        //public async void Test()
        //{
        //     await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
        //    using var ctx = new TestContext();

        //    var lines = "TestUser";

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add(p => p.name, lines)
              
        //    );
            
        //}
     
        //[Fact]
        //public void Test()
        //{
        //    using var ctx = new TestContext();

        //    var cut = ctx.RenderComponent<User>(parameters => parameters
        //      .Add<Alert>(p => p.Content, alertParameters => alertParameters
        //        .Add(p => p.name, "Alert heading")

        //      )
        //    );
        //}


    }
}
