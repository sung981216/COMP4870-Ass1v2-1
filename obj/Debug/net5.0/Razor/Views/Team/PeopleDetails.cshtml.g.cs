#pragma checksum "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f01109278fe3b0ca9b519bc3018bb5baebb0847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_PeopleDetails), @"mvc.1.0.view", @"/Views/Team/PeopleDetails.cshtml")]
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
#line 1 "C:\Users\sayed\assignment01\Views\_ViewImports.cshtml"
using assignment01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sayed\assignment01\Views\_ViewImports.cshtml"
using assignment01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f01109278fe3b0ca9b519bc3018bb5baebb0847", @"/Views/Team/PeopleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749b7e8ff4cb13358e3a45553e19f7dd8d315218", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_PeopleDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<assignment01.Models.People>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
  
  ViewData["Title"] = "Player Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n  <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n  <table class=\"table table-striped table-bordered\">\r\n    <tr>\r\n      <th>");
#nullable restore
#line 13 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
     Write(Html.DisplayNameFor(model => model.fullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 14 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
     Write(Html.DisplayNameFor(model => model.currentTeam.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 15 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
     Write(Html.DisplayNameFor(model => model.currentAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 16 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
     Write(Html.DisplayNameFor(model => model.nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 17 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
     Write(Html.DisplayNameFor(model => model.primaryPosition.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th></th>\r\n    </tr>\r\n   \r\n      <tr>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
       Write(Model.fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
       Write(Model.currentTeam.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
       Write(Model.currentAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n        <td>");
#nullable restore
#line 25 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
       Write(Model.nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n        <td>");
#nullable restore
#line 26 "C:\Users\sayed\assignment01\Views\Team\PeopleDetails.cshtml"
       Write(Model.primaryPosition.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n");
            WriteLiteral("      </tr>\r\n      \r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<assignment01.Models.People> Html { get; private set; }
    }
}
#pragma warning restore 1591
