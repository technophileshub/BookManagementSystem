#pragma checksum "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff9f5cbe0f24b152d5d2b59c171619b7834fede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookManagement.Pages.Pages_Help), @"mvc.1.0.razor-page", @"/Pages/Help.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Help.cshtml", typeof(BookManagement.Pages.Pages_Help), null)]
namespace BookManagement.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff9f5cbe0f24b152d5d2b59c171619b7834fede", @"/Pages/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592c63409c18ea073a249343662479537112b349", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Help : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/help/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 249, true);
            WriteLiteral("\r\n<h1>Help / Documentation</h1>\r\n<h2>Homepage:</h2>\r\nHome page contains statistics for Number of Books, Number of Programming Books, Number of Patrons, Number of Patrons by gender. Also, it contains the links for company information and contacts. \r\n");
            EndContext();
            BeginContext(281, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25c4c8f52e384359b4068398372d81e4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(314, 1597, true);
            WriteLiteral(@"
 
 
<h2>About Page:</h2>
 



<h2>Contact Page:</h2>
 
<h2>Administration Pages:</h2>
Here, we have three pages of Administration which include Book Management, Patron Management, and Reservation Management. 
 




<h2>For Book Management:</h2>

We can Create/Edit/Delete and show the Details of books, patrons, and reservations in these sections.
To Create information of the new books, click on “Administration > Book Management > Create New Book”. 
 
 
<h2>There are the screenshots of the Edit/Details/Delete:</h2>
 
 
 
<h2>For Patron Management:</h2>
  
  
 
<h2>For Reservation Management:</h2>
     
<h2>Custom Pages:</h2> 
<h2>There are three custom pages which include Books by Genre, Reservation by Return Date, and Reservation by Patron.  In the Books by Genre, it shows the collection data of genre of each book. “Reservation by Return Date” shows the data of return time, book title and borrow date. Int eh reservation by Patron page, it shows the relationships among three m");
            WriteLiteral(@"odels:</h2> Books(Title/Author), Patron (Borrower), Reservation (Expected Return Date).

 
  
<h2>Custom Forms:</h2>
 
This page shows Id=3 didn’t have the reservation. 
 
<h2>When customers search the id=5, the screen result will show the borrowed details as fallowing:</h2>
 
<h2>When customers search the id=5 in Return Book page, the screen result will show the borrowed details as fallowing:</h2>

 
In Borrow Book page, select the book from the drop down. 
 
<h2>One Validation for each book is allowed:</h2> only one reservation for each book. 
 

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelpModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelpModel>)PageContext?.ViewData;
        public HelpModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
