#pragma checksum "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aad5ca7133104c349c7f3369ac2d58b31eec678"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_ViewWedding), @"mvc.1.0.view", @"/Views/Wedding/ViewWedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/ViewWedding.cshtml", typeof(AspNetCore.Views_Wedding_ViewWedding))]
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
#line 1 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aad5ca7133104c349c7f3369ac2d58b31eec678", @"/Views/Wedding/ViewWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_ViewWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Wedding.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Weddings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wedding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 3 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(60, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(64, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2aad5ca7133104c349c7f3369ac2d58b31eec6785600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(112, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(116, 25, true);
            WriteLiteral("\n<h1 class=\"Text-center\">");
            EndContext();
            BeginContext(142, 15, false);
#line 9 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
                   Write(Model.Wedders());

#line default
#line hidden
            EndContext();
            BeginContext(157, 37, true);
            WriteLiteral("</h1>\n<div class=\"text-center\"> \n    ");
            EndContext();
            BeginContext(194, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aad5ca7133104c349c7f3369ac2d58b31eec6787353", async() => {
                BeginContext(244, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(257, 9, true);
            WriteLiteral("<br>\n    ");
            EndContext();
            BeginContext(266, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aad5ca7133104c349c7f3369ac2d58b31eec6788913", async() => {
                BeginContext(313, 7, true);
                WriteLiteral("Logout ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(324, 28, true);
            WriteLiteral(" \n</div>\n<p>Wedding\'s date: ");
            EndContext();
            BeginContext(353, 34, false);
#line 14 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
              Write(Model.Date.ToString("MMM-dd-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(387, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(392, 24, false);
#line 14 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
                                                     Write(Model.Date.ToString("t"));

#line default
#line hidden
            EndContext();
            BeginContext(416, 17, true);
            WriteLiteral("</p>\n<p>Address: ");
            EndContext();
            BeginContext(434, 15, false);
#line 15 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
       Write(Model.Address());

#line default
#line hidden
            EndContext();
            BeginContext(449, 22, true);
            WriteLiteral("</p>\n\n<div>Attendees: ");
            EndContext();
            BeginContext(472, 21, false);
#line 17 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
           Write(Model.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(493, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 19 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
     foreach (var user in Model.Attendees)
    {

#line default
#line hidden
            BeginContext(544, 16, true);
            WriteLiteral("        <p></p>\n");
            EndContext();
#line 22 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
        if(@user.User.UserId == @Model.CreatorId)
        {

#line default
#line hidden
            BeginContext(620, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(636, 20, false);
#line 24 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
          Write(user.User.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(656, 19, true);
            WriteLiteral(" (Coordinator)</p>\n");
            EndContext();
#line 25 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(708, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(724, 20, false);
#line 28 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
          Write(user.User.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(744, 14, true);
            WriteLiteral(" (Guests)</p>\n");
            EndContext();
#line 29 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(774, 176, true);
            WriteLiteral("</div>\n\n<div class=\"center\">\n<div class=\"col-9 d-flex flex-wrap justify-content-center\">\n        <iframe width=\"600\" height=\"450\" frameborder=\"1\" style=\"border:1px solid grey;\"");
            EndContext();
            BeginWriteAttribute("src", " \n        src=\"", 950, "\"", 1103, 8);
            WriteAttributeValue("", 965, "https://www.google.com/maps/embed/v1/place?key=AIzaSyBcbGOQQ4Zk3sFgmqmGCEA-H_r7tnlglwk&q=", 965, 89, true);
#line 36 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1054, Model.Street, 1054, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1067, "+", 1067, 1, true);
#line 36 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1068, Model.City, 1068, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1079, "+", 1079, 1, true);
#line 36 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1080, Model.State, 1080, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1092, "+", 1092, 1, true);
#line 36 "/Users/user/coding dojo/csharpNew/entityFramework/manyToMany/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1093, Model.Zip, 1093, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1104, 59, true);
            WriteLiteral(" \n        allowfullscreen></iframe>\n      </div>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
