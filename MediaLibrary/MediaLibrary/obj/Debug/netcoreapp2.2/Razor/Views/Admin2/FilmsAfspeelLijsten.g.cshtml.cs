#pragma checksum "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e83be65d1a94f490b7db546610becdc2bf796dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin2_FilmsAfspeelLijsten), @"mvc.1.0.view", @"/Views/Admin2/FilmsAfspeelLijsten.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin2/FilmsAfspeelLijsten.cshtml", typeof(AspNetCore.Views_Admin2_FilmsAfspeelLijsten))]
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
#line 1 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\_ViewImports.cshtml"
using MediaLibrary;

#line default
#line hidden
#line 2 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\_ViewImports.cshtml"
using MediaLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e83be65d1a94f490b7db546610becdc2bf796dc", @"/Views/Admin2/FilmsAfspeelLijsten.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e158b8d1cdfffa0e6488478e6ea3530cc1f31e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin2_FilmsAfspeelLijsten : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaLibrary.Models.Afspeellijst.ListFilmAfspeellijstViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilmsAfspeelLijsten", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Afspeellijsten", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Media", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gebruiker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
  
    ViewData["Title"] = "FilmsAfspeelLijsten";

#line default
#line hidden
            BeginContext(141, 32, true);
            WriteLiteral("\r\n<h1>FilmsAfspeelLijsten</h1>\r\n");
            EndContext();
            BeginContext(173, 320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e83be65d1a94f490b7db546610becdc2bf796dc5547", async() => {
                BeginContext(225, 120, true);
                WriteLiteral("\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Find by name: <input type=\"text\" name=\"SearchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 345, "\"", 379, 1);
#line 11 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
WriteAttributeValue("", 353, ViewData["currentFilter"], 353, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(380, 106, true);
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Search\" class=\"btn-secondary\" /> \r\n        </p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(493, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(582, 38, false);
#line 21 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(620, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(676, 41, false);
#line 24 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
           Write(Html.DisplayNameFor(model => model.Titel));

#line default
#line hidden
            EndContext();
            BeginContext(717, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(773, 48, false);
#line 27 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
           Write(Html.DisplayNameFor(model => model.Beschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(821, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 29 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(899, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(942, 41, false);
#line 32 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
               Write(Html.DisplayNameFor(model => model.Privé));

#line default
#line hidden
            EndContext();
            BeginContext(983, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 34 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
            }

#line default
#line hidden
            BeginContext(1023, 67, true);
            WriteLiteral("\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 42 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
             if (item.Privé == false || User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(1219, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1292, 37, false);
#line 46 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1409, 40, false);
#line 49 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titel));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1529, 47, false);
#line 52 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Beschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 54 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(1678, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1737, 40, false);
#line 57 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Privé));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
            BeginContext(1812, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1871, 74, false);
#line 61 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                       Write(Html.ActionLink("Delete", "FilmsAfspeelLijstDelete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 63 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                    }

#line default
#line hidden
            BeginContext(2001, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2052, 86, false);
#line 65 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
                   Write(Html.ActionLink("Detail", "FilmAfspeellijstDetail", "Gebruiker", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
            }

#line default
#line hidden
#line 68 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2216, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 72 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(2273, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2277, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e83be65d1a94f490b7db546610becdc2bf796dc15683", async() => {
                BeginContext(2308, 22, true);
                WriteLiteral("Back to afspeellijsten");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2334, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin2\FilmsAfspeelLijsten.cshtml"
}

#line default
#line hidden
            BeginContext(2339, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(2347, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e83be65d1a94f490b7db546610becdc2bf796dc17339", async() => {
                BeginContext(2396, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2404, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaLibrary.Models.Afspeellijst.ListFilmAfspeellijstViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
