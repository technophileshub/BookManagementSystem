#pragma checksum "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc1e9d23b09fbe9cd134ea77e3f4b382d0c0c65a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookManagement.Pages.Patrons.Pages_Patrons_Delete), @"mvc.1.0.razor-page", @"/Pages/Patrons/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Patrons/Delete.cshtml", typeof(BookManagement.Pages.Patrons.Pages_Patrons_Delete), null)]
namespace BookManagement.Pages.Patrons
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\_ViewImports.cshtml"
using BookManagement;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1e9d23b09fbe9cd134ea77e3f4b382d0c0c65a", @"/Pages/Patrons/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592c63409c18ea073a249343662479537112b349", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Patrons_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(100, 174, true);
            WriteLiteral("\r\n<h2>Delete Patron</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Patron</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(275, 47, false);
#line 16 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.Name));

#line default
#line hidden
            EndContext();
            BeginContext(322, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(366, 43, false);
#line 19 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.Name));

#line default
#line hidden
            EndContext();
            BeginContext(409, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(453, 54, false);
#line 22 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(507, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(551, 50, false);
#line 25 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(645, 50, false);
#line 28 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(695, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(739, 46, false);
#line 31 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(785, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(829, 59, false);
#line 34 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(932, 55, false);
#line 37 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(987, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1031, 57, false);
#line 40 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1132, 53, false);
#line 43 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1229, 49, false);
#line 46 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1322, 45, false);
#line 49 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1411, 50, false);
#line 52 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1505, 46, false);
#line 55 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patron.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1589, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c583c6fb0b46278e9479d9691d1a89", async() => {
                BeginContext(1609, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1619, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "749a180472254cc9877ea862a45b9f18", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Patrons\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Patron.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1662, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1746, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a6b89efb91c4741baf624226cc2104b", async() => {
                    BeginContext(1768, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1784, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1797, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookManagement.Pages.Patrons.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookManagement.Pages.Patrons.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookManagement.Pages.Patrons.DeleteModel>)PageContext?.ViewData;
        public BookManagement.Pages.Patrons.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
