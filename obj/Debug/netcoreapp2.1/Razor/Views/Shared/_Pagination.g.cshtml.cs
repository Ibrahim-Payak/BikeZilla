#pragma checksum "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d673390eaecbb30ae8938dd9d1d604c983bad619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Pagination), @"mvc.1.0.view", @"/Views/Shared/_Pagination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Pagination.cshtml", typeof(AspNetCore.Views_Shared__Pagination))]
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
#line 1 "C:\Projects\BikeZilla\BikeZilla\Views\_ViewImports.cshtml"
using BikeZilla;

#line default
#line hidden
#line 2 "C:\Projects\BikeZilla\BikeZilla\Views\_ViewImports.cshtml"
using BikeZilla.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d673390eaecbb30ae8938dd9d1d604c983bad619", @"/Views/Shared/_Pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878b53769fef89dca99a993a4bc6e5bd30b5128b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pageNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "page-item disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(126, 677, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9215fafab2d042cb85ba20d1b7487141", async() => {
                BeginContext(790, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#line 6 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = Model.PageNumber;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = Model.TotalItems;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 10 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
             WriteLiteral(ViewData["Controller"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __cloudscribe_Web_Pagination_PagerTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 11 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
         WriteLiteral(ViewData["Action"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __cloudscribe_Web_Pagination_PagerTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__cloudscribe_Web_Pagination_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "cloudscribe.Web.Pagination.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
                   WriteLiteral(ViewBag.currentSortOrder);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 14 "C:\Projects\BikeZilla\BikeZilla\Views\Shared\_Pagination.cshtml"
                      WriteLiteral(ViewBag.currentSearch);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["searchString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchString", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["searchString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(803, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
