﻿using BionicApp.Data;
using BionicApp.Pages.Add_Device.App_Info;
using BionicApp.Utils;
using Bunit;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using Ossur.Bionics.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BionicAppTestRunner.BionicAppUi
{
    public class INfoTCUi : BionicAppUiTestBase
    {
        [Fact]
        public void CheckIconButton()
        {

            var component = RenderComponent<InfoTC>();
            var mudStack = component.FindComponent<MudStack>();
            Assert.Equal(2, mudStack.Instance.Spacing);
            Assert.Equal("pa-4", mudStack.Instance.Class);
            Assert.False(mudStack.Instance.Row);
            var mudGrid = mudStack.FindComponent<MudGrid>();
            Assert.Equal(2, mudGrid.Instance.Spacing);
            Assert.Equal(Justify.FlexStart, mudGrid.Instance.Justify);
            var mudIcon = mudGrid.FindComponent<MudIconButton>();
            Assert.Equal(Icons.Material.Filled.ArrowBack, mudIcon.Instance.Icon);
        }
        [Fact]
        public async void CheckTermUseText()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<InfoTC>();
            var mudtext = component.FindComponents<MudText>()[0];
            Assert.Equal("pa-2", mudtext.Instance.Class);
            Assert.Equal(Typo.h6, mudtext.Instance.Typo);
            Assert.Equal(Align.Center, mudtext.Instance.Align);
            mudtext.MarkupMatches("<h6 class=\"mud-typography mud-typography-h6 mud-typography-align-center pa-2\">Terms of Use Agreement</h6>");
        }
        [Fact]
        public async void CheckTermDiscText()
        {
            await Manager.Instance.Login("https://bionicregistry40dev.azurewebsites.net/api/v1", "tst_admin@example.com", "tst_admin_42");
            const string key = "TranslationCutoffDate";
            var cutoff = Manager.Instance.GetValue(key, DateTime.MinValue);
            await Manager.Instance.CloudSync.PullTranslationsFromCloud(cutoff, 1, 1000, "en", "USERAPP_V1.0");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en");
            var component = RenderComponent<InfoTC>();
            var mudtext = component.FindComponents<MudText>()[1];
            mudtext.MarkupMatches("<p class=\"mud-typography mud-typography-body1\"><!-- Össur Inc EULA for Össur User App January 2023 --> <!-- copyright (C) 2023, össur inc, http://ossur.com --> <html>  <head>    <style>       body {          margin-top: 20;          font-family: \"OpenSans-Light\";          font-size: 1em;       }        p,       li {          font-size: 0.8em;          color: #333333;          padding-left: 2px;          margin-top: 8px;       }        h1 {          font-size: 1.2em;          color: #526471;          padding-left: 2px;       }        h2 {          font-size: 1.0em;          color: #526471;          padding-left: 2px;          margin-top: 16px;       }    </style>    <meta charset=\"UTF-8\"> </head>  <body>    <h1>Össur User App Terms of Use Agreement – 1<sup>st</sup> of January, 2019</span></h1>    <p>This Terms of Use Agreement ('Agreement') is entered into by and between Össur Americas Inc. ('Owner') and 'you,'       the user of this app software, also known as the Össur User App APP ('APP'). Access to and use of the APP is provided       subject to the terms and conditions set forth herein. By downloading, accessing and using the APP, you hereby       agree to these terms and conditions.</p>    <p>THIS AGREEMENT CONTAINS WARRANTY DISCLAIMERS AND OTHER PROVISIONS THAT LIMIT THE OWNER'S LIABILITY TO YOU. PLEASE       READ THESE TERMS AND CONDITIONS CAREFULLY AND IN THEIR ENTIRETY, AS ACCESSING AND USING THE APP CONSTITUTES       ACCEPTANCE OF THESE TERMS AND CONDITIONS. IF YOU DO NOT AGREE TO BE BOUND TO EACH AND EVERY TERM AND CONDITION SET       FORTH HEREIN, PLEASE EXIT THE APP IMMEDIATELY AND DO NOT ACCESS AND/OR USE THE APP.</p>    <p>BY ENTERING THE APP, YOU ACKNOWLEDGE AND AGREE THAT YOU HAVE READ AND UNDERSTAND THESE TERMS AND CONDITIONS, THAT       THE PROVISIONS, DISCLOSURES AND DISCLAIMERS SET FORTH HEREIN ARE FAIR AND REASONABLE, AND THAT YOUR AGREEMENT TO       FOLLOW AND BE BOUND BY THESE TERMS AND CONDITIONS IS VOLUNTARY AND IS NOT THE RESULT OF FRAUD, DURESS OR UNDUE       INFLUENCE EXERCISED UPON YOU BY ANY PERSON OR ENTITY.</p>     <h2>MEDICAL ADVICE DISCLAIMER</h2>    <p>The Owner provides the APP and the software, services, information, content and/or data (collectively,       \"Information\") contained therein for process purposes only. The Owner does not provide any medical advice on or       related to the APP, and the Information should not be so construed or used. Accessing and using the APP and/or       providing personal or medical information to the Owner does not create a physician-patient relationship between       you and the Owner. Nothing contained in the APP is intended to create a physician-patient relationship, to replace       the services of a licensed, trained physician or health professional, or to be a substitute for medical advice of       a physician or trained health professional licensed in your Jurisdiction. You hereby agree that you shall not make       any health or medical related decision based in whole or in part on anything contained in the APP. You hereby       agree that all actions you take based on the APP´s suggestions or training program are at your own risk.</p>    <h2>FINANCIAL, LEGAL AND OTHER ADVICE DISCLAIMER</h2>    <p>You hereby acknowledge that nothing contained in the APP shall constitute financial, investment, legal and/or       other professional advice and that no professional relationship of any kind is created between you and the Owner.       You hereby agree that you shall not make any financial, investment, legal and/or other decision based solely or in       part on anything contained in the APP.</p>     <h2>INFORMATION DISCLAIMER</h2>    <p>Any Information of the Owner or the APP is or has been rendered based on specific facts, under certain conditions,       and subject to certain assumptions, and may not and should not be used or relied upon by you for any other       purpose, including, but not limited to, use in or in connection with any legal proceeding. The Information is not       guaranteed to be complete, correct, timely, current or up-to-date. Similar to any printed materials, the       Information may become out-of-date. The Owner undertakes no obligation to update any Information on the APP. The       Owner reserves the right to make alterations or deletions to the Information at any time without notice.</p>     <h2>UPDATES</h2>    <p>The Owner may from time to time in its sole discretion develop and provide APP updates, which may include       upgrades, bug fixes, patches and other error corrections and/or new features (collectively, including related       documentation, 'Updates'). Updates may also modify or delete in their entirety certain features and functionality.       You agree that the Owner has no obligation to provide any Updates or to continue to provide or enable any       particular features or functionality. Based on your Device settings, when your Device is connected to the internet       either:       <ol type='a'>          <li> the APP will automatically download and install all available Updates; or</li>          <li> You may receive notice of or be prompted to download and install available Updates.</li>       </ol>       <p>You shall promptly download and install all Updates and acknowledge and agree that the APP or portions thereof          may not properly operate should you fail to do so. You further agree that all Updates will be deemed part of          the APP and be subject to all terms and conditions of this Agreement.</p>        <h2>INFORMATION GATHERING</h2>       <p>You acknowledge that when you download, install or use the APP, the Owner may use automatic means to collect          information about your device and about your use of the APP. You also may be required to provide certain          information about yourself as a condition to downloading, installing or using the APP or certain of its          features or functionality, and the APP may provide you with opportunities to share information about yourself          with others. All information we collect through or in connection with this APP is subject to our Privacy          Notice. By downloading, installing, using and providing information to or through this APP, you consent to all          actions taken by us with respect to your information in compliance with the Privacy Notice. </p>        <h2>POSTING GUIDELINES</h2>       <p>By uploading or otherwise making available any information to the Owner, you grant the Owner the unlimited,          perpetual right to distribute, display, publish, reproduce, reuse and copy the information contained therein.          You are responsible for the content you post. You may not impersonate any other person through the APP. You may          not post content that is obscene, defamatory, threatening, fraudulent, invasive of another person's privacy          rights, or is otherwise unlawful in accordance to the Privacy Notice and applicable Privacy Laws. You may not          post content that infringes the intellectual property rights of any other person or entity. You may not post          any content that contains any computer viruses or any other code designed to disrupt, damage, or limit the          functioning of any computer software or hardware. By submitting or posting content on the APP, you grant the          Owner and any company substantially under the control of the Owner, the right to remove any content or comment          that, in Owner's sole judgment, does not comply with the terms and conditions of this Agreement or is otherwise          objectionable. You also grant the Owner and any company substantially under the control of Owner the right to          modify, adapt, and edit any content.</p>        <h2>INFORMATION DISCLAIMER</h2>       <p>The Information made available at the APP is provided on an \"AS IS\" and \"AS AVAILABLE\" basis without warranties          of any kind, either express or implied, including, without limitation, warranties of title, non-infringement,          and implied warranties of merchantability or fitness for a particular purpose. Without limiting the generality          of the foregoing, the Owner makes no warranty, representation or guaranty as to the content, sequence,          accuracy, timeliness or completeness of the Information, that the Information may be relied upon for any reason          or that the Information will be uninterrupted or error free or that any defects can or will be corrected.          Without limiting the generality of the foregoing, the Owner makes no representations or warranties with respect          to any Information offered or provided within or through the APP regarding treatment of medical conditions,          action, or application of medication. Under no circumstances, as a result of your use of the APP, will the          Owner be liable to you or to any other person for any direct, indirect, special, incidental, exemplary,          consequential or other damages under any legal theory, including, without limitation, tort, contract, strict          liability or otherwise, even if advised of the possibility of such damages. Without limiting the generality of          the foregoing, the Owner shall have absolutely no liability in connection with the APP for:          <ol>             <li>Damages as a result of lost profits, loss of good will, work stoppage, failure of performance, delays in                operation or transmission, non-delivery of information, deletions of files, mistakes, defects, errors,                interruptions or equipment failure or malfunction;             <li>Any loss or injury caused, in whole or in part, by the Owner's actions, omissions, or negligence, or for                contingencies beyond the Owner's control, in procuring, compiling, or delivering the Information;             <li>Any errors, omissions, or inaccuracies in the Information regardless of how caused, or delays or                interruptions in delivery of the Information; or</li>             <li>Any decision made or action taken or not taken in reliance upon the Information.          </ol>       </p>        <h2>RESERVATION OF INTELLECTUAL PROPERTY RIGHTS</h2>       <p>The APP is protected by United States copyright laws. The Owner hereby reserves any and all intellectual          property rights in the APP.</p>       <h2>AGE RESTRICTION</h2>       <p>The APP is intended for persons eighteen (18) years or older. Persons under the age of eighteen (18) should not          access, use and/or browse the APP.</p>       <h2>HIPAA</h2>       <p>Business Associates shall be responsible for following all compliance issues related to HIPAA. Business          Associates and Owner will enter into a HIPAA Business Associate Agreement in form and substance reasonably          satisfactory to the Parties and compliant with then-applicable law.</p>       <p> Business Associate. “Business Associate” shall have the same meaning as the term “business associate” at 45          CFR § 160.103 Definitions (2013 HIPAA Omnibus Rule)</p>       <h2>INDEMNIFICATION</h2>       <p>You agree to indemnify and hold the Owner harmless from any claim or demand, including attorneys' fees, made by          any third party as a result of          <ol type='a'>             <li>any content posted or made available by you on this APP,</li>             <li>any violation of law that occurs by you through the APP, and/or</li>             <li>anything you do using the APP and/or the Information contained therein.</li>          </ol>       </p>        <h2>INVALIDITY</h2>       <p>If any provision of this Agreement is held to be invalid or unenforceable in whole or in part in any          jurisdiction, then that provision shall be deemed ineffective in such jurisdiction but shall have no effect on          the enforceability of the remaining provisions.</p>        <h2>GOVERNING LAW, CONSENT TO JURISDICTION AND LIMITATION ON CLAIMS</h2>       <p>This Agreement and your use of the APP, along with the Information contained therein, shall be governed by and          construed in accordance with the laws of the State of New York without regard to conflict of laws principles,          and you agree to submit to the jurisdiction of Federal Courts in the State of New York. You further agree that          any claims or causes of action arising out of or related to this Agreement and the APP, along with the          Information contained therein, shall be filed within one (1) year after such claim or cause of action arose, or          such claim or cause of action shall be forever barred.</p>        <h2>ENTIRE AGREEMENT</h2>       <p>You hereby acknowledge that this Agreement represents the entire understanding between you and the Owner          concerning your use of the APP and the Information contained therein.</p>        <h2>MODIFICATION</h2>       <p>The Owner may, in the Owner's sole and absolute discretion, modify the terms and conditions of this Agreement          in whole or in part at any time for any reason without any notice to you, whether prior or otherwise. Such          modified terms and conditions shall supersede these terms and conditions and shall become binding when          published online on the APP.</p>        <h2>WAIVER</h2>       <p>The Owner's failure to exercise or enforce any right or provision of this Agreement shall not be deemed to be a          waiver of such right or provision.</p>       <p>THE APP AND THE INFORMATION CONTAINED THEREIN IS MADE AVAILABLE BY THE OWNER FOR SERVICE PROCESS PURPOSES ONLY          AND IS NOT INTENDED TO PROVIDE MEDICAL ADVICE. BY ACCESSING THE APP, YOU UNDERSTAND AND ACKNOWLEDGE THAT THERE          IS NO PHYSICIAN-PATIENT RELATIONSHIP BETWEEN YOU AND THE OWNER.</p> </body>  </html></p>");
        }
    }
}