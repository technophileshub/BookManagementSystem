#pragma checksum "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d8525889586a0c8f7627fcd450cee189531f27d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookManagement.Pages.Pages_PatronReservations), @"mvc.1.0.razor-page", @"/Pages/PatronReservations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PatronReservations.cshtml", typeof(BookManagement.Pages.Pages_PatronReservations), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8525889586a0c8f7627fcd450cee189531f27d", @"/Pages/PatronReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592c63409c18ea073a249343662479537112b349", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PatronReservations : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(53, 17, false);
#line 6 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
Write(Model.Patron.Name);

#line default
#line hidden
            EndContext();
            BeginContext(70, 285, true);
            WriteLiteral(@" Reservations </h3>
<table class=""table"">
    <thead>
        <th>
            Title
        </th>
        <th>
            Author
        </th>
        <th>
            Borrow Date
        </th>
        <th>
            Expected Return Date
        </th>
    </thead>
");
            EndContext();
#line 22 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
 foreach( var item in Model.Patron.Reservations)
{

#line default
#line hidden
            BeginContext(408, 24, true);
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(433, 15, false);
#line 26 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
   Write(item.Book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(448, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(480, 16, false);
#line 29 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
   Write(item.Book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(496, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(528, 15, false);
#line 32 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
   Write(item.BorrowDate);

#line default
#line hidden
            EndContext();
            BeginContext(543, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(575, 15, false);
#line 35 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
   Write(item.ReturnDate);

#line default
#line hidden
            EndContext();
            BeginContext(590, 20, true);
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
            EndContext();
#line 38 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\PatronReservations.cshtml"
}

#line default
#line hidden
            BeginContext(613, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatronReservationsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PatronReservationsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PatronReservationsModel>)PageContext?.ViewData;
        public PatronReservationsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
