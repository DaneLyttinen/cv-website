#pragma checksum "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\Pages\Sub.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4252f13a6ea5c0b0f07c705852eb1e8434f4a3a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorRealTime.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using BlazorRealTime.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using BlazorRealTime.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\_Imports.razor"
using BlazorFluentUI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/portfolio")]
    public partial class Sub : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "the nav-link");
            __builder.AddAttribute(2, "id", "monkey");
            __builder.AddAttribute(3, "href", "monkeys");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<h1 class=\"display-4\">Shakespearean monkeys</h1>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "the nav-link");
            __builder.AddAttribute(9, "id", "notflix");
            __builder.AddAttribute(10, "href", "https://github.com/DaneLyttinen/Movie_watching_website");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "<h1 class=\"display-4\">Notflix</h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
