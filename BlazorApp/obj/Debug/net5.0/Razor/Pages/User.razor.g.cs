#pragma checksum "E:\source\repos\BlazorApp\BlazorApp\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f19b37c29c26f7b041c5bf2e8e8907ede1e9977"
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
#line 1 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/{id}")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Donor</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "non-resizableButton");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "E:\source\repos\BlazorApp\BlazorApp\Pages\User.razor"
                                              MakeAppointment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Make Appointment");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "E:\source\repos\BlazorApp\BlazorApp\Pages\User.razor"
       
    [Parameter]
    public string id { get; set; }
    void MakeAppointment()
    {
        NavManager.NavigateTo($"/Appointment/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
