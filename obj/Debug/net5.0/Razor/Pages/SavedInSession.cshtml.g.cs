#pragma checksum "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2344202e0ffef5824ce020e8473db2fde7741996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LeapYears.Pages.Pages_SavedInSession), @"mvc.1.0.razor-page", @"/Pages/SavedInSession.cshtml")]
namespace LeapYears.Pages
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
#line 1 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\_ViewImports.cshtml"
using LeapYears;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2344202e0ffef5824ce020e8473db2fde7741996", @"/Pages/SavedInSession.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd5a5ebe6f347c6bcbd2b4a2f1c1a70151ecf3f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SavedInSession : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Zadanie - rok przestępny</h1>\r\n");
#nullable restore
#line 6 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
     if (Model.yearsList != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n\r\n");
#nullable restore
#line 10 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
             foreach (var item in Model.yearsList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>\r\n                    ");
#nullable restore
#line 13 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 13 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
                           Write(item.year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - rok\r\n\r\n");
#nullable restore
#line 15 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
                     if (@item.ExtraYear())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>przestępny</span>\r\n");
#nullable restore
#line 18 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>nieprzestępny</span>\r\n");
#nullable restore
#line 22 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n                <br />\r\n");
#nullable restore
#line 26 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 29 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad 3-4 - lata przestępne (sesja+baza_danych)\LeapYears\Pages\SavedInSession.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeapYears.Pages.SavedInSessionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeapYears.Pages.SavedInSessionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeapYears.Pages.SavedInSessionModel>)PageContext?.ViewData;
        public LeapYears.Pages.SavedInSessionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591