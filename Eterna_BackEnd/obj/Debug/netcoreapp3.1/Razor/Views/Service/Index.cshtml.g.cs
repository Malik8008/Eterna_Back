#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "decfaa53ce1ec9cbe5cd02d0ee4f6460de91b1ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\_ViewImports.cshtml"
using Eterna_BackEnd.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\_ViewImports.cshtml"
using Eterna_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\_ViewImports.cshtml"
using Eterna_BackEnd.ViewModels.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decfaa53ce1ec9cbe5cd02d0ee4f6460de91b1ad", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5906bc8258097ddfa7ddc91b66bd4098afc42893", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- main section begin -->
<main>
    <section class=""services"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-4 col-sm-4 home"">
                    <span>Home / Services</span>
                    <h2>Services</h2>
                </div>
            </div>
        </div>
    </section>
    <section class=""menu mt-2 d-flex justify-content-between"">
        <div class=""container"">
            <div class=""row d-flex justify-content-between"">
");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                 foreach (Card card in Model.Cards)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"col-lg-4 col-md-6 col-sm-12\">\r\n                    <div class=\"box\">\r\n                        <div class=\"basket mt-5\">\r\n                            <div class=\"icon\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 892, "\"", 910, 1);
#nullable restore
#line 29 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
WriteAttributeValue("", 900, card.Icon, 900, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                            <div class=\"title mt-2\">\r\n                                <h2>");
#nullable restore
#line 32 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                               Write(card.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                            <div class=\"description mt-2\">\r\n                                <p>");
#nullable restore
#line 35 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                              Write(card.Dexcription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\n");
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"skills mt-3\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 47 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                 foreach (Skill skill in Model.Skills)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n                    <div class=\"skil\">\r\n                        <h2>");
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                       Write(skill.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <hr>\r\n                    <div class=\"Magnam\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                   Write(skill.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\n");
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"diagram mt-4\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "decfaa53ce1ec9cbe5cd02d0ee4f6460de91b1ad8815", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2158, "~/assets/IMG/diagram-image/", 2158, 27, true);
#nullable restore
#line 66 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
AddHtmlAttributeValue("", 2185, layoutserice.GetDatas().Result.FirstOrDefault(i=>i.Key=="ProgressImage").Value, 2185, 79, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-6"">
                    <div class=""about"">
                        <h3>Voluptatem dignissimos provident quasi corporis voluptates</h3>
                    </div>
                    <div class=""info"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda</p>
                    </div>
");
#nullable restore
#line 75 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                     foreach (ProgressBar prog in Model.Progresss)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"programming d-flex justify-content-between mt-4\">\r\n                        <span>");
#nullable restore
#line 78 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                         Write(prog.Program);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span>");
#nullable restore
#line 79 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                         Write(prog.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                    </div>\r\n                    <div class=\"progress\">\r\n                        <div class=\"progress-bar bg-danger\"\r\n                             role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 3180, "\"", 3210, 3);
            WriteAttributeValue("", 3188, "width:", 3188, 6, true);
#nullable restore
#line 83 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
WriteAttributeValue(" ", 3194, prog.Percent, 3195, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3208, "%;", 3208, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                             aria-valuemax=\"25\" aria-valuemin=\"0\"\r\n                             aria-valuemax=\"100\"></div>\r\n                    </div>\n");
#nullable restore
#line 87 "C:\Users\Admin\OneDrive\Desktop\Eterna_BackEnd\Eterna_BackEnd\Views\Service\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n<!-- main section end -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Eterna_BackEnd.Service.LayoutService layoutserice { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
