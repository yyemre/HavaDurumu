#pragma checksum "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e9ba01b4653bbc45721dbb690ea6e08b4e690d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\_ViewImports.cshtml"
using HavaDurumu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\_ViewImports.cshtml"
using HavaDurumu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9ba01b4653bbc45721dbb690ea6e08b4e690d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb4b23392cd432ee03fb7876cfbf3a3609591d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HavaDurumuApi2.Models.Data>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 6 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
         using (Html.BeginForm("Index", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 9 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
       Write(Html.DropDownList("Hava Durumu", new SelectList(Model, "Sehir", "Sehir"), "Şehir Seçin", new { @Sehir = "Sehir" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <input type=\"submit\" value=\"Filtrele\" />\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"button\" value=\"Filtreleri Kaldır\"");
            BeginWriteAttribute("onclick", " onclick=\"", 472, "\"", 547, 2);
#nullable restore
#line 16 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
WriteAttributeValue("", 482, "window.location.href='" + @Url.Action("Index", "Home") + "'", 482, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 546, ";", 546, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <td>ID</td>\r\n                <td>Şehir</td>\r\n                <td>Derece</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
                   Write(Html.DisplayTextFor(m => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
                   Write(Html.DisplayTextFor(m => item.Sehir));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
                   Write(Html.DisplayTextFor(m => item.Derece));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <input type=\"button\" value=\"Hava Durumu Ekle\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1161, "\"", 1235, 2);
#nullable restore
#line 33 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1171, "window.location.href='" + @Url.Action("Index", "Add") + "'", 1171, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1234, ";", 1234, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    }\r\n");
#nullable restore
#line 35 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"text\" class=\"form-control\" name=\"ID\", id=\"ID\" />\r\n            <input type=\"submit\" value=\"Arama yap\" />\r\n");
#nullable restore
#line 39 "C:\Users\nyks9\source\repos\HavaDurumu\HavaDurumuApi2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HavaDurumuApi2.Models.Data>> Html { get; private set; }
    }
}
#pragma warning restore 1591
