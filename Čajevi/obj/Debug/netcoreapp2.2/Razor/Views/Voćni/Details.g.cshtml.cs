#pragma checksum "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0583a6063058e5c73512c9d41945fb788ee18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voćni_Details), @"mvc.1.0.view", @"/Views/Voćni/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Voćni/Details.cshtml", typeof(AspNetCore.Views_Voćni_Details))]
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
#line 1 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\_ViewImports.cshtml"
using Čajevi;

#line default
#line hidden
#line 2 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\_ViewImports.cshtml"
using Čajevi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0583a6063058e5c73512c9d41945fb788ee18d", @"/Views/Voćni/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525ed91c6790ed9e35f559b75c5da743fc1e96af", @"/Views/_ViewImports.cshtml")]
    public class Views_Voćni_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Čajevi.Models.Voćni>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Voćni</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(202, 39, false);
#line 14 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(241, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(305, 35, false);
#line 17 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(340, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(403, 46, false);
#line 20 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.podrijetlo));

#line default
#line hidden
            EndContext();
            BeginContext(449, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(513, 42, false);
#line 23 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayFor(model => model.podrijetlo));

#line default
#line hidden
            EndContext();
            BeginContext(555, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(618, 41, false);
#line 26 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.vrsta));

#line default
#line hidden
            EndContext();
            BeginContext(659, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(723, 37, false);
#line 29 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayFor(model => model.vrsta));

#line default
#line hidden
            EndContext();
            BeginContext(760, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(823, 42, false);
#line 32 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.godina));

#line default
#line hidden
            EndContext();
            BeginContext(865, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(929, 38, false);
#line 35 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayFor(model => model.godina));

#line default
#line hidden
            EndContext();
            BeginContext(967, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1030, 42, false);
#line 38 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.kilaza));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1136, 38, false);
#line 41 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayFor(model => model.kilaza));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1237, 42, false);
#line 44 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.komada));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1343, 38, false);
#line 47 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
       Write(Html.DisplayFor(model => model.komada));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1428, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0583a6063058e5c73512c9d41945fb788ee18d9576", async() => {
                BeginContext(1474, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "E:\@Dokumenti\_-VSITE-_\III.godina\V. SEMSETAR\PIN\@PROJEKT\Čajevi\Čajevi\Views\Voćni\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1482, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1490, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0583a6063058e5c73512c9d41945fb788ee18d11918", async() => {
                BeginContext(1512, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1528, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Čajevi.Models.Voćni> Html { get; private set; }
    }
}
#pragma warning restore 1591
