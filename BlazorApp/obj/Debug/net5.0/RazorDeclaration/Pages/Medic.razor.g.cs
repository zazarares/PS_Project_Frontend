// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
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
#line 4 "E:\source\repos\BlazorApp\BlazorApp\Pages\Medic.razor"
using SendGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\source\repos\BlazorApp\BlazorApp\Pages\Medic.razor"
using SendGrid.Helpers.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\source\repos\BlazorApp\BlazorApp\Pages\Medic.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\source\repos\BlazorApp\BlazorApp\Pages\Medic.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\source\repos\BlazorApp\BlazorApp\Pages\Medic.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/medic/{id}")]
    public partial class Medic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\source\repos\BlazorApp\BlazorApp\Pages\Medic.razor"
       
    
    List<Appointment_U> LA = new List<Appointment_U>();
    [Parameter]
    public string id { get; set; }
    string Appointment_to_notify;
    Smart.Blazor.TableColumn[] columns = new Smart.Blazor.TableColumn[] {
        new Smart.Blazor.TableColumn()
        {
            Label = "id",
            DataField = "id",
        },
        new Smart.Blazor.TableColumn()
        {
            Label = "Date",
            DataField = "Date"
        },
        new Smart.Blazor.TableColumn()
        {
            Label = "timeslot",
            DataField = "timeslot"
        },
        new Smart.Blazor.TableColumn()
        {
            Label = "DoctorID",
            DataField = "DoctorID"
        },
        new Smart.Blazor.TableColumn()
        {
            Label = "DonatorID",
            DataField = "DonatorID"
        }


    };

    List<string> S = new List<string>();
    List<Doctor> DL = new List<Doctor>();
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
            DL = JsonConvert.DeserializeObject<List<Doctor>>(responseStream);
            StateHasChanged();
        }
        else
        {
        }
    }
    public async Task sendEmail()
    {

        NavManager.NavigateTo($"SendResults/{id}/{Appointment_to_notify}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
