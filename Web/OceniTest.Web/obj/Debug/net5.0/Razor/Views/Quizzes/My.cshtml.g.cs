#pragma checksum "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05e67b4916ef73dfafd557f7abb49866f278ce3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quizzes_My), @"mvc.1.0.view", @"/Views/Quizzes/My.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e67b4916ef73dfafd557f7abb49866f278ce3b", @"/Views/Quizzes/My.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76c876668b4fa6546085cf60b7b0ae36b52080c", @"/Views/_ViewImports.cshtml")]
    public class Views_Quizzes_My : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OceniTest.Web.ViewModels.Pagination.PaginatedListViewModel<OceniTest.Web.ViewModels.Quizzes.SurveyViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
  
    this.ViewData["Title"] = "My Surveys";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"surveys\">\r\n");
#nullable restore
#line 8 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
     foreach (var survey in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article class=\"surveys-item\">\r\n            <article class=\"survey\"");
            BeginWriteAttribute("id", " id=\"", 317, "\"", 332, 1);
#nullable restore
#line 11 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
WriteAttributeValue("", 322, survey.Id, 322, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h3 class=\"survey-name\">");
#nullable restore
#line 12 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
                                   Write(survey.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"survey-creation\">");
#nullable restore
#line 13 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
                                      Write(survey.CreatedOn.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"survey-description\">");
#nullable restore
#line 14 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
                                         Write(survey.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"survey-visibility\">");
#nullable restore
#line 15 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
                                        Write(survey.Visibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </article>\r\n            <p class=\"view-btn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05e67b4916ef73dfafd557f7abb49866f278ce3b6828", async() => {
                WriteLiteral("See Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
                                                                                  WriteLiteral(survey.Id);

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
            WriteLiteral("</p>\r\n        </article>\r\n");
#nullable restore
#line 19 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n<section class=\"pagination\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05e67b4916ef73dfafd557f7abb49866f278ce3b9449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 23 "C:\Users\123\OneDrive\Работен плот\ASP .NET Core Project\OceniTest\Web\OceniTest.Web\Views\Quizzes\My.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OceniTest.Web.ViewModels.Pagination.PaginatedListViewModel<OceniTest.Web.ViewModels.Quizzes.SurveyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
