#pragma checksum "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Pages\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9634103f43d33eea466b28f00bb87737e202da1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addproduct")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex justify-content-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-12 col-md-6");
            __builder.OpenComponent<BlazorApp.Shared.AddProductForm>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591