#pragma checksum "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_SearchForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea871ee7b0bc38a49285a3b6d8a6177c1369c026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingCartStore.Web.Views.Shared.Views_Shared__SearchForm), @"mvc.1.0.view", @"/Views/Shared/_SearchForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SearchForm.cshtml", typeof(ShoppingCartStore.Web.Views.Shared.Views_Shared__SearchForm))]
namespace ShoppingCartStore.Web.Views.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using SoppingCartStore.Web;

#line default
#line hidden
#line 3 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.Product;

#line default
#line hidden
#line 4 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.Category;

#line default
#line hidden
#line 5 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.Brand;

#line default
#line hidden
#line 6 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.Cart;

#line default
#line hidden
#line 7 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.Item;

#line default
#line hidden
#line 8 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.CreditCard;

#line default
#line hidden
#line 9 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.ViewModels.Customer;

#line default
#line hidden
#line 10 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.BindingModels.Product;

#line default
#line hidden
#line 11 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.BindingModels.CreditCard;

#line default
#line hidden
#line 12 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\_ViewImports.cshtml"
using ShoppingCartStore.Common.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea871ee7b0bc38a49285a3b6d8a6177c1369c026", @"/Views/Shared/_SearchForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f9fee60a5b25c28ac2f1799138a7ae4259b8e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SearchForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 835, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea871ee7b0bc38a49285a3b6d8a6177c1369c0265933", async() => {
                BeginContext(64, 79, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12 col-lg-4\">\r\n            ");
                EndContext();
                BeginContext(144, 41, false);
#line 4 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_SearchForm.cshtml"
       Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
                EndContext();
                BeginContext(185, 72, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-12 col-lg-4\">\r\n            ");
                EndContext();
                BeginContext(258, 37, false);
#line 7 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_SearchForm.cshtml"
       Write(await Component.InvokeAsync("Brands"));

#line default
#line hidden
                EndContext();
                BeginContext(295, 533, true);
                WriteLiteral(@"
        </div>
        <div class=""col-sm-12 col-lg-4"">
            <h5>Search:</h5>
            <div class=""row"">
                <div class=""col-lg-8"">
                    <input name=""SearchFilter"" class=""form-control mr-sm-2 "" type=""search"" placeholder=""By name"" aria-label=""Search"">
                </div>
                <div class=""col-lg-4"">
                    <button class=""btn btn-outline-info my-2 my-sm-0"" type=""submit"">Search</button>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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