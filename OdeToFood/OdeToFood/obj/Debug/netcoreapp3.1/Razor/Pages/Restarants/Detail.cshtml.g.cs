#pragma checksum "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42509cfe594613f1d6aa67cd39492174f2c132d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restarants.Pages_Restarants_Detail), @"mvc.1.0.razor-page", @"/Pages/Restarants/Detail.cshtml")]
namespace OdeToFood.Pages.Restarants
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
#line 1 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restarantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42509cfe594613f1d6aa67cd39492174f2c132d", @"/Pages/Restarants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c9a00489a771a5c519ca5c9bef1c07c3c26080", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restarants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: dodgerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!--above is the route, what the path should look like -->\n");
#nullable restore
#line 4 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 8 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
Write(Model.Restarant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<div>\n    id: ");
#nullable restore
#line 11 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
   Write(Model.Restarant.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<div>\n    Location: ");
#nullable restore
#line 15 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
         Write(Model.Restarant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<div>\n    Cuisine: ");
#nullable restore
#line 19 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
        Write(Model.Restarant.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
#nullable restore
#line 22 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
 if(Model.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color: red;\">");
#nullable restore
#line 24 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
                        Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 25 "/Users/ebenburger/Documents/dev/EbenSandbox/OdeToFood/OdeToFood/Pages/Restarants/Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42509cfe594613f1d6aa67cd39492174f2c132d6095", async() => {
                WriteLiteral("All Restaurants");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<!--this is what the page will look like.-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailModel>)PageContext?.ViewData;
        public DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591