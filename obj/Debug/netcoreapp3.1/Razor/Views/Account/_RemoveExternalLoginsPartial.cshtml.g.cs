#pragma checksum "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c138d0046576d5ceb3825950481be43128ce2865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__RemoveExternalLoginsPartial), @"mvc.1.0.view", @"/Views/Account/_RemoveExternalLoginsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c138d0046576d5ceb3825950481be43128ce2865", @"/Views/Account/_RemoveExternalLoginsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a46ea64d99171699ed00aa92bb246498522dc8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__RemoveExternalLoginsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Login.Models.ExternalLogin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Inicios de sesión externos registrados</h3>\r\n    <table>\r\n        <tbody>\r\n");
#nullable restore
#line 8 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
         foreach (Login.Models.ExternalLogin externalLogin in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 11 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
               Write(externalLogin.ProviderDisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 13 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                     if (ViewBag.ShowRemoveButton)
                    {
                        using (Html.BeginForm("Disassociate", "Account"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <fieldset>\r\n                                ");
#nullable restore
#line 19 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                           Write(Html.Hidden("provider", externalLogin.Provider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 20 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                           Write(Html.Hidden("providerUserId", externalLogin.ProviderUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <input type=\"submit\" value=\"Quitar\"");
            BeginWriteAttribute("title", " title=\"", 855, "\"", 936, 8);
            WriteAttributeValue("", 863, "Quitar", 863, 6, true);
            WriteAttributeValue(" ", 869, "esta", 870, 5, true);
            WriteAttributeValue(" ", 874, "credencial", 875, 11, true);
            WriteAttributeValue(" ", 885, "de", 886, 3, true);
#nullable restore
#line 21 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
WriteAttributeValue(" ", 888, externalLogin.ProviderDisplayName, 889, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 923, "de", 924, 3, true);
            WriteAttributeValue(" ", 926, "su", 927, 3, true);
            WriteAttributeValue(" ", 929, "cuenta", 930, 7, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </fieldset>\r\n");
#nullable restore
#line 23 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral(" &nbsp;\r\n");
#nullable restore
#line 28 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 34 "C:\Users\caldao\Desktop\Capacitaciones\Platzi\MVCExample\Views\Account\_RemoveExternalLoginsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Login.Models.ExternalLogin>> Html { get; private set; }
    }
}
#pragma warning restore 1591