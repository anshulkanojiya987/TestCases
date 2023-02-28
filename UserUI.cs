using BionicApp.Pages.Add_Device;
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
            Assert.NotNull(avtar);
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
    }
}
