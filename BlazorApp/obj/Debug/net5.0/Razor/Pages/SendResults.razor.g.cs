#pragma checksum "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974ef0c5f0c453cc10ce9068bdcbd31adb00154a"
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
#line 3 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SendResults/{appid}/{doctorid}")]
    public partial class SendResults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SendResults</h3>\r\n");
            __builder.AddMarkupContent(1, "<label>SMS</label>\r\n");
            __builder.OpenComponent<Smart.Blazor.RadioButton>(2);
            __builder.AddAttribute(3, "OnCheckValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 8 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
                                        OnCheckValueB1

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Value", "B1");
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
            __builder.AddMarkupContent(6, "<label>Email</label>\r\n");
            __builder.OpenComponent<Smart.Blazor.RadioButton>(7);
            __builder.AddAttribute(8, "OnCheckValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 11 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
                                        OnCheckValueB2

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.AddMarkupContent(10, "<label>Remarks:</label>\r\n");
            __builder.OpenElement(11, "textarea");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
                 rez

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rez = __value, rez));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<br>\r\n");
            __builder.OpenComponent<Smart.Blazor.Button>(15);
            __builder.AddAttribute(16, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
                              sendAppointment

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "Send Appointment");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddMarkupContent(20, @"<style>

    body {
        color: white;
        text-align: center;
        vertical-align: central;
        background-image: url(https://as2.ftcdn.net/v2/jpg/01/34/88/19/1000_F_134881906_gdIsbeci13e4p6XZ3Kn0l0MYmrueJ20q.jpg);
        background-repeat: no-repeat;
        background-size: cover;
    }

</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\source\repos\BlazorApp\BlazorApp\Pages\SendResults.razor"
       
    bool B1;
    bool B2;
    string rez;
    List<Appointment_U> LA;
    List<Doctor> LD;
    List<Donator> LDD;
    List<User_Working> LU;
    [Parameter]
    public string appid { get; set; }
    [Parameter]
    public string doctorid{ get; set; }
    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44321/Appointment");
        var Client = ClientFactory.CreateClient();
        var response = await Client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            LA = JsonConvert.DeserializeObject<List<Appointment_U>>(responseStream);
            for (int i = 0; i < LA.Count; i++)
                if (LA.ElementAt(i).DoctorID != 1)
                    ;
            //DoctorList = DoctorListC.Doc;
            StateHasChanged();
        }
        else
        {
        }
        request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44321/Doctor");
        response = await Client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            LD = JsonConvert.DeserializeObject<List<Doctor>>(responseStream);
            StateHasChanged();
        }
        else
        {
        }
        request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44321/Donator");
        response = await Client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            LDD = JsonConvert.DeserializeObject<List<Donator>>(responseStream);
            StateHasChanged();
        }
        else
        {
        }
        request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44321/WeatherForecastService");
        response = await Client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            LU = JsonConvert.DeserializeObject<List<User_Working>>(responseStream);
            StateHasChanged();
        }
        else
        {
        }
    }

    public void OnCheckValueB1()
    {
        B1=true;
        B2=false;
    }
    public void OnCheckValueB2()
    {
        B1 = false;
        B2 = true;
    }
    public async Task sendAppointment()
    {
        Doctor D=new Doctor();
        for(int i=0;i<LD.Count;i++)
            if(LD.ElementAt(i).id==Int32.Parse(doctorid))
                D = LD.ElementAt(i);
        Appointment_U A=new Appointment_U();
        for (int i = 0; i < LD.Count; i++)
            if (LA.ElementAt(i).id == Int32.Parse(appid))
                A = LA.ElementAt(i);
        if (B1)
        {

            var Client = ClientFactory.CreateClient();
            SMS S=new SMS();
            S.Content = rez;
            S.To = LDD.ElementAt(A.DonatorID).telefon;
            var toSend = System.Text.Json.JsonSerializer.Serialize(S);

            var req = new StringContent(toSend, System.Text.Encoding.UTF8, "application/json");
            var response_donator = await Client.PostAsync("https://localhost:44321/SMS",req );

        }
        if (B2)
        {
            var Client = ClientFactory.CreateClient();
            Email E = new Email();
            E.Content = rez;
            E.To = LU.ElementAt(A.DonatorID).username;
            E.PatientName = LDD.ElementAt(A.DonatorID).FirstName + " " + LDD.ElementAt(A.DonatorID).LastName;
            E.From = LD.ElementAt(A.DoctorID).FirstName + " " + LD.ElementAt(A.DoctorID).FirstName;
            E.subject = "Results";
            var toSend = System.Text.Json.JsonSerializer.Serialize(E);

            var req = new StringContent(toSend, System.Text.Encoding.UTF8, "application/json");
            var response_donator = await Client.PostAsync("https://localhost:44321/Email", req);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591