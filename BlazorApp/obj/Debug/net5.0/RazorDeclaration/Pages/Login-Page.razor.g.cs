// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    public partial class Login_Page : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
       
    public string Password { get; set; }
    public string Email { get; set; }

    [Parameter]
    public string myvalue { get; set; }

    public async void CheckLogin(MouseEventArgs mouseEventArgs)
    {
        DateTime dt = DateTime.Now;
        for (int i = 0; i < branches.Count; i++)
            if (Email.Equals(branches.ElementAt(i).username))
                if (Password.Equals(branches.ElementAt(i).password))
                {
                    i++;
                    string s = i.ToString();
                    i--;
                    switch (branches.ElementAt(i).userType)
                    {

                        case 0:
                            NavManager.NavigateTo("/Admin");
                            break;
                        case 1:
                            NavManager.NavigateTo($"/Medic/{s}");
                            break;
                        case 2:

                            NavManager.NavigateTo($"/User/{s}");
                            goto functionend;
                    }
                }
            functionend:;
    }

    protected void CreateAccountPage(MouseEventArgs mouseEventArgs)
    {
        NavManager.NavigateTo("/CreateAccount");
    }
    protected override void OnParametersSet()
    {
        //the param will be set now
        var test = myvalue;

    }
    List<User_Working> branches = new List<User_Working>();
    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44321/WeatherForecastService");
        var Client = ClientFactory.CreateClient();
        var response = await Client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            branches = await JsonSerializer.DeserializeAsync<List<User_Working>>(responseStream);
        }
        else
        {
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
