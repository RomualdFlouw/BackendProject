#pragma checksum "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734e690d7bafc2a34b9be586b378658a6fe1996c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieRoom_Index), @"mvc.1.0.view", @"/Views/MovieRoom/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieRoom/Index.cshtml", typeof(AspNetCore.Views_MovieRoom_Index))]
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
#line 1 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\_ViewImports.cshtml"
using CinemaDemoWebApp;

#line default
#line hidden
#line 2 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\_ViewImports.cshtml"
using CinemaDemoWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734e690d7bafc2a34b9be586b378658a6fe1996c", @"/Views/MovieRoom/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84f04aa2014e2ed010edac2a8d0dc1c642a1e987", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieRoom_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaDemoModels.Models.MovieRoom>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "734e690d7bafc2a34b9be586b378658a6fe1996c3865", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 309, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                RoomId
            </th>
            <th>
                MovieId
            </th>
            <th>
                PlayTime
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(505, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(554, 41, false);
#line 31 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomId));

#line default
#line hidden
            EndContext();
            BeginContext(595, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(651, 42, false);
#line 34 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieId));

#line default
#line hidden
            EndContext();
            BeginContext(693, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(749, 43, false);
#line 37 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlayTime));

#line default
#line hidden
            EndContext();
            BeginContext(792, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(848, 48, false);
#line 40 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(896, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(917, 52, false);
#line 41 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(969, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "D:\School\ASP.NET\2.LABO\BackendProject\CinemaDemoWebApp\Views\MovieRoom\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1008, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaDemoModels.Models.MovieRoom>> Html { get; private set; }
    }
}
#pragma warning restore 1591