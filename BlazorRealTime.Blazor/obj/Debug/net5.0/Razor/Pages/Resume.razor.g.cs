#pragma checksum "C:\Users\Dane\source\repos\BlazorRealTime\BlazorRealTime.Blazor\Pages\Resume.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c44ee39e867bdb58d6894aaa8b9251ca1bc775a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/resume")]
    public partial class Resume : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>My Resume</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"resume\"><img src=\"images/resume-1.jpg\" height=\"800px\" width=\"650px\"></div>\r\n");
            __builder.AddMarkupContent(2, "<a href=\"~/images/\" class=\"portfolio btn\" download=\"Resume-converted.pdf\" target=\"_top\">download</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591