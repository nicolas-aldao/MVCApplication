#pragma checksum "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70de20d260eb9f9edfbc90016c83e3473c73883b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\_ViewImports.cshtml"
using Platzi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\_ViewImports.cshtml"
using Platzi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70de20d260eb9f9edfbc90016c83e3473c73883b", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a46ea64d99171699ed00aa92bb246498522dc8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login.Models.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Registrarse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hgroup class=\"title\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n    <h2>Cree una cuenta nueva.</h2>\r\n</hgroup>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Formulario de registro</legend>\r\n        <ol>\r\n            <li>\r\n                ");
#nullable restore
#line 19 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
#nullable restore
#line 23 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
#nullable restore
#line 27 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input type=\"submit\" value=\"Registrarse\" />\r\n    </fieldset>\r\n");
#nullable restore
#line 33 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 36 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Register.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Login.Models.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
