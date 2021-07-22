#pragma checksum "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a88a5e97e6c733aca2f71498aa3a86851e97d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quizzes_Overview), @"mvc.1.0.view", @"/Views/Quizzes/Overview.cshtml")]
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
#line 1 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\_ViewImports.cshtml"
using OceniTest.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\_ViewImports.cshtml"
using OceniTest.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a88a5e97e6c733aca2f71498aa3a86851e97d2c", @"/Views/Quizzes/Overview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76c876668b4fa6546085cf60b7b0ae36b52080c", @"/Views/_ViewImports.cshtml")]
    public class Views_Quizzes_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OceniTest.Web.ViewModels.Quizzes.SurveyOverviewViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Downloads", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
  
    var questionNumber = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article class=\"survey-overview\">\r\n    <section class=\"survey-overview-header\">\r\n        <h1 class=\"survey-overview-header-name\">\r\n            ");
#nullable restore
#line 10 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
       Write(this.Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <h3 class=\"survey-overview-header-title\">\r\n            ");
#nullable restore
#line 13 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
       Write(this.Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n    </section>\r\n    <section class=\"survey-overview-content\">\r\n");
#nullable restore
#line 17 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
         foreach (var question in Model.Questions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <article class=\"survey-overview-content-question\">\r\n                <p>");
#nullable restore
#line 20 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
               Write($"{questionNumber}. {question.Description}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <section class=\"survey-overview-content-question-answers\">\r\n");
#nullable restore
#line 22 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
                     foreach (var answer in question.Answers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <article class=\"survey-overview-answer\">\r\n                            <input");
            BeginWriteAttribute("name", " name=\"", 901, "\"", 920, 1);
#nullable restore
#line 25 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
WriteAttributeValue("", 908, question.Id, 908, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("value", " value=\"", 934, "\"", 961, 1);
#nullable restore
#line 25 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
WriteAttributeValue("", 942, answer.Description, 942, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <label>");
#nullable restore
#line 26 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
                              Write(answer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </article>\r\n");
#nullable restore
#line 28 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </section>\r\n            </article>\r\n");
#nullable restore
#line 31 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"

            questionNumber++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n    <section class=\"survey-overview-download\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a88a5e97e6c733aca2f71498aa3a86851e97d2c7990", async() => {
                WriteLiteral("Download Survey");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\Overview.cshtml"
                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n    </section>\r\n</article>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OceniTest.Web.ViewModels.Quizzes.SurveyOverviewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591