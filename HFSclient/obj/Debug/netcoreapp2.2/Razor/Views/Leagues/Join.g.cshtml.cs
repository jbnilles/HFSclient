#pragma checksum "C:\users\Jeffrey\documents\epicodus\csharp\hfsclient.solution\hfsclient\Views\Leagues\Join.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "976edd9194a9e6670b982381f077694a18689408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leagues_Join), @"mvc.1.0.view", @"/Views/Leagues/Join.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Leagues/Join.cshtml", typeof(AspNetCore.Views_Leagues_Join))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976edd9194a9e6670b982381f077694a18689408", @"/Views/Leagues/Join.cshtml")]
    public class Views_Leagues_Join : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HFSclient.Models.League>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\users\Jeffrey\documents\epicodus\csharp\hfsclient.solution\hfsclient\Views\Leagues\Join.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(62, 24, true);
            WriteLiteral("\r\n<h3>Join this League: ");
            EndContext();
            BeginContext(87, 42, false);
#line 6 "C:\users\Jeffrey\documents\epicodus\csharp\hfsclient.solution\hfsclient\Views\Leagues\Join.cshtml"
                 Write(Html.DisplayFor(model => model.LeagueName));

#line default
#line hidden
            EndContext();
            BeginContext(129, 13, true);
            WriteLiteral("</h3>\r\n<br>\r\n");
            EndContext();
            BeginContext(447, 9, true);
            WriteLiteral("<br>\r\n<p>");
            EndContext();
            BeginContext(457, 85, false);
#line 18 "C:\users\Jeffrey\documents\epicodus\csharp\hfsclient.solution\hfsclient\Views\Leagues\Join.cshtml"
Write(Html.ActionLink("Cancel", "Index", null, null, new {@class="btn btn-primary btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(542, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HFSclient.Models.League> Html { get; private set; }
    }
}
#pragma warning restore 1591