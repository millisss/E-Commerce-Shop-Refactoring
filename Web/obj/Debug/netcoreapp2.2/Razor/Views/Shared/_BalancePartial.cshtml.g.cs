#pragma checksum "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_BalancePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12fbe9378c32ba0bf9ca4f8bdb1adfaecf4c01a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingCartStore.Web.Views.Shared.Views_Shared__BalancePartial), @"mvc.1.0.view", @"/Views/Shared/_BalancePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_BalancePartial.cshtml", typeof(ShoppingCartStore.Web.Views.Shared.Views_Shared__BalancePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12fbe9378c32ba0bf9ca4f8bdb1adfaecf4c01a6", @"/Views/Shared/_BalancePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f9fee60a5b25c28ac2f1799138a7ae4259b8e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BalancePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_BalancePartial.cshtml"
 if (User.IsInRole("Administrator"))
{
    

#line default
#line hidden
            BeginContext(46, 38, false);
#line 3 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_BalancePartial.cshtml"
Write(await Component.InvokeAsync("Balance"));

#line default
#line hidden
            EndContext();
#line 3 "C:\Users\user\Desktop\ShoppingCartStore-master\src\Web\Views\Shared\_BalancePartial.cshtml"
                                           
}

#line default
#line hidden
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
