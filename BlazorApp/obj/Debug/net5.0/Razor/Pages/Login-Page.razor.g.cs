#pragma checksum "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1153e54928f2edafdafe299157750a5f7b868259"
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
            __builder.AddMarkupContent(0, "<h2>Please log in to continue</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "test-div");
            __builder.OpenElement(3, "fieldset");
            __builder.AddAttribute(4, "class", "Field1");
            __builder.OpenElement(5, "label");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddAttribute(7, "for", "Email");
            __builder.AddMarkupContent(8, "\r\n            Email:\r\n            <br>\r\n            ");
            __builder.OpenElement(9, "textarea");
            __builder.AddAttribute(10, "class", "non_resizable_text_area");
            __builder.AddAttribute(11, "id", "Email");
            __builder.AddAttribute(12, "cols", "50");
            __builder.AddAttribute(13, "rows", "1");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
                                                                                           Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        <br>\r\n        ");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "class", "row");
            __builder.AddAttribute(19, "for", "Password");
            __builder.AddMarkupContent(20, "\r\n            Password:\r\n            <br>\r\n            ");
            __builder.OpenElement(21, "textarea");
            __builder.AddAttribute(22, "class", "non_resizable_text_area");
            __builder.AddAttribute(23, "id", "Password");
            __builder.AddAttribute(24, "cols", "50");
            __builder.AddAttribute(25, "rows", "1");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
                                                                                              Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "non_resizable_button");
            __builder.AddAttribute(31, "type", "submit");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
                                                                      CheckLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n            Login\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        <br>\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "non_resizable_button");
            __builder.AddAttribute(37, "type", "submit");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\source\repos\BlazorApp\BlazorApp\Pages\Login-Page.razor"
                                                                      CreateAccountPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "\r\n            CreateAccount\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.AddMarkupContent(41, @"<style>
    .test-div {
        vertical-align: central;
    }

    .Field1 {
        display: table;
        display: inline-block;
        align-content: center;
        align-self: center;
        text-align: center;
    }

    .row {
        display: table-row;
        text-align: center;
    }

    .non_resizable_text_area {
        resize: none;
        display: table-cell;
        text-align: center;
    }

    .non_resizable_button {
        resize: none;
        margin-top: 4px;
        display: table-cell;
    }

    h2 {
        text-align: center;
        font-size: 15px;
        align-content: center;
    }

    body {
        text-align: center;
        vertical-align: central;
        background-image: url(https://cdn5.vectorstock.com/i/1000x1000/57/64/blood-donation-background-with-donation-vector-14615764.jpg);
        background-repeat: no-repeat;
        background-size: cover;
        margin-top: 25%;
    }

    form1 {
        display: inline-block;
        align-items: center;
        align-self: center;
        text-align: center;
        align-content: center;
    }

    label {
        text-align: center;
        font-size: 15px;
        align-content: center;
    }

    input {
        text-align: center;
        align-content: center;
    }
</style>");
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
