#pragma checksum "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f5479302f8c0f189a8b39a2055914e50c1a2f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PodcastList), @"mvc.1.0.view", @"/Views/Admin/PodcastList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/PodcastList.cshtml", typeof(AspNetCore.Views_Admin_PodcastList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f5479302f8c0f189a8b39a2055914e50c1a2f1", @"/Views/Admin/PodcastList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e158b8d1cdfffa0e6488478e6ea3530cc1f31e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PodcastList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaLibrary.Models.ListPodcastsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
  
    ViewData["Title"] = "PodcastList";

#line default
#line hidden
            BeginContext(112, 35, true);
            WriteLiteral("\r\n<h1>PodcastList</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5f5479302f8c0f189a8b39a2055914e50c1a2f13946", async() => {
                BeginContext(170, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(184, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(277, 41, false);
#line 16 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.DisplayNameFor(model => model.Titel));

#line default
#line hidden
            EndContext();
            BeginContext(318, 131, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <p>Speeltijd(min)</p>\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(450, 40, false);
#line 22 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(490, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(608, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(657, 40, false);
#line 31 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titel));

#line default
#line hidden
            EndContext();
            BeginContext(697, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(753, 41, false);
#line 34 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lengte));

#line default
#line hidden
            EndContext();
            BeginContext(794, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 37 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
                 if (item.Foto == null)
                {

#line default
#line hidden
            BeginContext(893, 50, true);
            WriteLiteral("                    <p>Geen foto beschikbaar</p>\r\n");
            EndContext();
#line 40 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
                }
                else
                {
                    var base64 = Convert.ToBase64String(item.Foto);
                    var imgSrc = String.Format("data:image/gif;base64,{0}", base64);


#line default
#line hidden
            BeginContext(1160, 55, true);
            WriteLiteral("                    <div>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1215, "\"", 1228, 1);
#line 47 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
WriteAttributeValue("", 1221, imgSrc, 1221, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 56, true);
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\r\n                    </div>\r\n");
            EndContext();
#line 50 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
                }

#line default
#line hidden
            BeginContext(1304, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1358, 65, false);
#line 53 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1444, 71, false);
#line 54 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1536, 64, false);
#line 55 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
           Write(Html.ActionLink("Delete", "PodcastDelete", new {  id=item.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Admin\PodcastList.cshtml"
}

#line default
#line hidden
            BeginContext(1639, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaLibrary.Models.ListPodcastsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591