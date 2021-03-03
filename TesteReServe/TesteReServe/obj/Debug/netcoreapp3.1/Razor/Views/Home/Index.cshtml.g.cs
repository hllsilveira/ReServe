#pragma checksum "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b54ea9f84bf163f7d81c90ea310396f1cdeaf1d"
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
#line 1 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\_ViewImports.cshtml"
using TesteReServe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\_ViewImports.cshtml"
using TesteReServe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b54ea9f84bf163f7d81c90ea310396f1cdeaf1d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d22af5024c22b8bc4ab997e82a80eca81e4a83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TesteReServe.Models.CovidPais>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Listagem de Paises com maiores casos de Covid-19</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
          
            if (Model.Count() <= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\r\n                    <h4>Não foi possível localizar as informações !</h4>\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-striped table-hover"">
                    <thead>
                        <tr>
                            <th style=""width: 10%"">Ranking</th>
                            <th style=""width: 20%"">Nome do País</th>
                            <th style=""width: 70%"">Casos Ativos</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
                           
                            int index = 1;
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td style=\"width: 10%\" class=\"align-middle\">\r\n                                        ");
#nullable restore
#line 35 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"width: 20%\">\r\n                                        ");
#nullable restore
#line 38 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
                                   Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"width: 70%\">\r\n                                        ");
#nullable restore
#line 41 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
                                    Write(item.TotalConfirmed - item.TotalRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"
                            }
                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 48 "C:\Users\Helton\Desktop\Teste\ReServe\TesteReServe\TesteReServe\Views\Home\Index.cshtml"

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TesteReServe.Models.CovidPais>> Html { get; private set; }
    }
}
#pragma warning restore 1591
