#pragma checksum "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e49db838ae5c5b2665921c538ec61e4edd953db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\_ViewImports.cshtml"
using WebUIProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\_ViewImports.cshtml"
using WebUIProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e49db838ae5c5b2665921c538ec61e4edd953db", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941e3e76536f8750774ff9fde69ee5f0e3434c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>??R??NLER L??STES?? : </h1>\r\n\r\n<table>\r\n    <thead>\r\n        <!--<tr>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>-->\r\n\r\n    </thead>\r\n\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
               Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
               Write(item.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Muhammed Berkay AKAR\Desktop\Dotnet_Core_E-itim_Notlarim\NorthwindLevelTwo\WebUIProject\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
