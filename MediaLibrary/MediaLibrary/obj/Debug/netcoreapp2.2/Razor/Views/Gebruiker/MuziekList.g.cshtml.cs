#pragma checksum "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3873621d6b493119b9e7cac87ce1eec5a578e479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gebruiker_MuziekList), @"mvc.1.0.view", @"/Views/Gebruiker/MuziekList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gebruiker/MuziekList.cshtml", typeof(AspNetCore.Views_Gebruiker_MuziekList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3873621d6b493119b9e7cac87ce1eec5a578e479", @"/Views/Gebruiker/MuziekList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e158b8d1cdfffa0e6488478e6ea3530cc1f31e", @"/Views/_ViewImports.cshtml")]
    public class Views_Gebruiker_MuziekList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaLibrary.Models.ListMuziekViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MuziekDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MuziekDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MuziekEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MuziekReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MuziekGeluisterd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Media", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gebruiker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
  
    ViewData["Title"] = "MuziekList";

#line default
#line hidden
            BeginContext(109, 113, true);
            WriteLiteral("\r\n<h1>MuziekList</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(223, 41, false);
#line 15 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
           Write(Html.DisplayNameFor(model => model.Titel));

#line default
#line hidden
            EndContext();
            BeginContext(264, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(320, 43, false);
#line 18 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
           Write(Html.DisplayNameFor(model => model.Artiest));

#line default
#line hidden
            EndContext();
            BeginContext(363, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(419, 40, false);
#line 21 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
           Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(459, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 23 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(544, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(587, 42, false);
#line 26 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(629, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 28 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
            }

#line default
#line hidden
            BeginContext(669, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
         foreach (var item in Model)
        {
            if (item.Hidden == true)
            {

#line default
#line hidden
            BeginContext(836, 65, true);
            WriteLiteral("                <tr><td>Dit item is niet beschikbaaar</td></tr>\r\n");
            EndContext();
#line 38 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
            }
            else
            {


#line default
#line hidden
            BeginContext(951, 74, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1026, 40, false);
#line 45 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titel));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1146, 42, false);
#line 48 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Artiest));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 57, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n");
            EndContext();
#line 52 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                         if (item.Foto == null)
                        {

#line default
#line hidden
            BeginContext(1321, 58, true);
            WriteLiteral("                            <p>Geen foto beschikbaar</p>\r\n");
            EndContext();
#line 55 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                        }
                        else
                        {
                            var base64 = Convert.ToBase64String(item.Foto);
                            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);


#line default
#line hidden
            BeginContext(1636, 71, true);
            WriteLiteral("                            <div>\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1707, "\"", 1720, 1);
#line 62 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
WriteAttributeValue("", 1713, imgSrc, 1713, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1721, 64, true);
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\r\n                            </div>\r\n");
            EndContext();
#line 65 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                        }

#line default
#line hidden
            BeginContext(1812, 27, true);
            WriteLiteral("                    </td>\r\n");
            EndContext();
#line 67 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(1919, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1978, 41, false);
#line 70 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 72 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                    }

#line default
#line hidden
            BeginContext(2075, 25, true);
            WriteLiteral("                    <td> ");
            EndContext();
            BeginContext(2100, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3873621d6b493119b9e7cac87ce1eec5a578e47913179", async() => {
                BeginContext(2176, 8, true);
                WriteLiteral("Details ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2188, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 74 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(2276, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(2305, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3873621d6b493119b9e7cac87ce1eec5a578e47916143", async() => {
                BeginContext(2381, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2391, 37, true);
            WriteLiteral(" </td>\r\n                        <td> ");
            EndContext();
            BeginContext(2428, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3873621d6b493119b9e7cac87ce1eec5a578e47918782", async() => {
                BeginContext(2502, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2510, 37, true);
            WriteLiteral(" </td>\r\n                        <td> ");
            EndContext();
            BeginContext(2547, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3873621d6b493119b9e7cac87ce1eec5a578e47921417", async() => {
                BeginContext(2623, 6, true);
                WriteLiteral("Review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2633, 37, true);
            WriteLiteral(" </td>\r\n                        <td> ");
            EndContext();
            BeginContext(2670, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3873621d6b493119b9e7cac87ce1eec5a578e47924056", async() => {
                BeginContext(2750, 11, true);
                WriteLiteral("Beluisterd?");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2765, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 80 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
                    }

#line default
#line hidden
            BeginContext(2796, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 82 "C:\Users\Student\source\repos\MediaDatabase\MediaLibrary\MediaLibrary\Views\Gebruiker\MuziekList.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2845, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2869, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3873621d6b493119b9e7cac87ce1eec5a578e47927273", async() => {
                BeginContext(2918, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaLibrary.Models.ListMuziekViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591