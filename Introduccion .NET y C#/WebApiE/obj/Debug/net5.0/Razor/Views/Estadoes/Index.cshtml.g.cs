#pragma checksum "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2507979d820ef960784fd575eedfc82a3b9ba8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estadoes_Index), @"mvc.1.0.view", @"/Views/Estadoes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2507979d820ef960784fd575eedfc82a3b9ba8d", @"/Views/Estadoes/Index.cshtml")]
    public class Views_Estadoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApiE.Data.Models.Estado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 587, "\"", 616, 1);
#nullable restore
#line 28 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
WriteAttributeValue("", 602, item.IdEstado, 602, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 669, "\"", 698, 1);
#nullable restore
#line 29 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
WriteAttributeValue("", 684, item.IdEstado, 684, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 753, "\"", 782, 1);
#nullable restore
#line 30 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
WriteAttributeValue("", 768, item.IdEstado, 768, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\WebApiE\Views\Estadoes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApiE.Data.Models.Estado>> Html { get; private set; }
    }
}
#pragma warning restore 1591