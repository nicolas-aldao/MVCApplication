#pragma checksum "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d7b2e9063159a26d3921397573468a720a0a4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Manage), @"mvc.1.0.view", @"/Views/Account/Manage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d7b2e9063159a26d3921397573468a720a0a4a", @"/Views/Account/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a46ea64d99171699ed00aa92bb246498522dc8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login.Models.LocalPasswordModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
  
    ViewBag.Title = "Administrar cuenta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hgroup class=\"title\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n</hgroup>\r\n\r\n<p class=\"message-success\">");
#nullable restore
#line 10 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
                      Write(ViewBag.StatusMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Ha iniciado sesión como <strong>");
#nullable restore
#line 12 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
                              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.</p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
 if (ViewBag.HasLocalPassword)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
Write(Html.Partial("_ChangePasswordPartial"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
                                           
}
else
{ 
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
Write(Html.Partial("_SetPasswordPartial"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
                                        
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"externalLogins\">\r\n    ");
#nullable restore
#line 24 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
Write(Html.Action("RemoveExternalLogins"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h3>Agregar un inicio de sesión externo</h3>\r\n    ");
#nullable restore
#line 27 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
Write(Html.Action("ExternalLoginsList", new { ReturnUrl = ViewBag.ReturnUrl }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\Manage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Login.Models.LocalPasswordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
