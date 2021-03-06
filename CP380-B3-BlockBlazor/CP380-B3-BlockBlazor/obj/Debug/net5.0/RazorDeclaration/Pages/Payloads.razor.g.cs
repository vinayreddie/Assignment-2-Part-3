// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CP380_B3_BlockBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using CP380_B3_BlockBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\_Imports.razor"
using CP380_B3_BlockBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
using CP380_B1_BlockList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
using CP380_B3_BlockBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/payloads")]
    public partial class Payloads : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
       
    private IEnumerable<Payload> payloads;
    private Payload payload = new Payload("", 0, 0, "");
    private string submitResponse = "";

    protected override async Task OnInitializedAsync()
    {
        // TODO: Fetch all the payloads from the service
        payloads = await pendingTransactionList.GetPayloadsAsync();
    }

    private async Task HandleValidSubmit()
    {
        // TODO: submit the new payload to the web API using the PendingTransactionService
        //       - if succcessful, the payloads should be re-loaded
        //       - if there is an error, then the submitResponse variable should be updated with the error
        var response = await pendingTransactionList.AddPayloadAsync(payload);
        if (response.IsSuccessStatusCode)
        {
            payloads = await pendingTransactionList.GetPayloadsAsync();
        }
        else
        {
            submitResponse = response.StatusCode.ToString();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PendingTransactionService pendingTransactionList { get; set; }
    }
}
#pragma warning restore 1591
