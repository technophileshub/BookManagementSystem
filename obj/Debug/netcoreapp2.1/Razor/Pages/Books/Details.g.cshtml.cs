#pragma checksum "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4317f92ea7b55374bffee4b41628efe5fd2be483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookManagement.Pages.Books.Pages_Books_Details), @"mvc.1.0.razor-page", @"/Pages/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Books/Details.cshtml", typeof(BookManagement.Pages.Books.Pages_Books_Details), null)]
namespace BookManagement.Pages.Books
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4317f92ea7b55374bffee4b41628efe5fd2be483", @"/Pages/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592c63409c18ea073a249343662479537112b349", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Books_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 123, true);
            WriteLiteral("\r\n<h2>Book Details</h2>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(224, 46, false);
#line 15 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Title));

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(314, 42, false);
#line 18 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Title));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 46, false);
#line 21 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(490, 42, false);
#line 24 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(576, 47, false);
#line 27 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(667, 43, false);
#line 30 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(754, 47, false);
#line 33 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Author));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 43, false);
#line 36 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Author));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(932, 48, false);
#line 39 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1024, 44, false);
#line 42 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1112, 46, false);
#line 45 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1202, 42, false);
#line 48 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1288, 45, false);
#line 51 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1377, 41, false);
#line 54 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1462, 54, false);
#line 57 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.NumberOfPages));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1560, 50, false);
#line 60 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.NumberOfPages));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1654, 50, false);
#line 63 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1748, 46, false);
#line 66 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1838, 54, false);
#line 69 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.PublishedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1936, 50, false);
#line 72 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.PublishedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2033, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d8edcf567f4767be6a89410ec25721", async() => {
                BeginContext(2084, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Details.cshtml"
                           WriteLiteral(Model.Book.Id);

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
            BeginContext(2092, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2100, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e646198aadf043db8d618f13870d0353", async() => {
                BeginContext(2122, 12, true);
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
            BeginContext(2138, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookManagement.Pages.Books.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookManagement.Pages.Books.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookManagement.Pages.Books.DetailsModel>)PageContext?.ViewData;
        public BookManagement.Pages.Books.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
