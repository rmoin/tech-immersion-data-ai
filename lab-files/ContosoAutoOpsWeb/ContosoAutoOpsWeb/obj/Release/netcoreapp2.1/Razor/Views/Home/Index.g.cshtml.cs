#pragma checksum "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c12fc7f62617a1e221935e90336e53e801fd361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\_ViewImports.cshtml"
using ContosoAutoOpsWeb;

#line default
#line hidden
#line 2 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\_ViewImports.cshtml"
using ContosoAutoOpsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c12fc7f62617a1e221935e90336e53e801fd361", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e382e56c9ea2654f46587aa4bebccf5f882820c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoAutoOpsWeb.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "ContosoAuto - Products";

#line default
#line hidden
            BeginContext(114, 201, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>Products</h2>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(316, 40, false);
#line 14 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(356, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(436, 49, false);
#line 17 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProductNumber));

#line default
#line hidden
            EndContext();
            BeginContext(485, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(565, 41, false);
#line 20 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(606, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(686, 52, false);
#line 23 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SafetyStockLevel));

#line default
#line hidden
            EndContext();
            BeginContext(738, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(818, 48, false);
#line 26 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ReorderPoint));

#line default
#line hidden
            EndContext();
            BeginContext(866, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(946, 48, false);
#line 29 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.StandardCost));

#line default
#line hidden
            EndContext();
            BeginContext(994, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1074, 45, false);
#line 32 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 38 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1310, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1395, 39, false);
#line 42 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1526, 48, false);
#line 45 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1666, 40, false);
#line 48 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1798, 51, false);
#line 51 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SafetyStockLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1941, 47, false);
#line 54 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReorderPoint));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2080, 47, false);
#line 57 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StandardCost));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2219, 44, false);
#line 60 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2263, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2354, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd0b87df9f946d4a338d3f7a7bce549", async() => {
                BeginContext(2416, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                                                             WriteLiteral(item.ProductID);

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
            BeginContext(2427, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 66 "Y:\tech-immersion-data-ai\lab-files\ContosoAutoOpsWeb\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2506, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoAutoOpsWeb.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
