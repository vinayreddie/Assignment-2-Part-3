#pragma checksum "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25c44134628d2fa966753236ef7a2fd43231de5c"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Pending Transactions</h3>");
#nullable restore
#line 9 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
 if (payloads == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "border", "1");
            __builder.AddAttribute(4, "cellpadding", "5");
            __builder.AddMarkupContent(5, "<thead><tr><th>User</th>\n                <th>Item</th>\n                <th>Transaction Type</th>\n                <th>Amount</th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
             foreach (var payload in payloads)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                         payload.User

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                         payload.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                         payload.TransactionType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                         payload.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<p></p>\n\n");
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, 
#nullable restore
#line 40 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
    submitResponse

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n\n<br>\n<br>\n");
            __builder.AddMarkupContent(23, "<h3>Add a Transaction</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 46 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                  payload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 46 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "<label for=\"user\">User</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "id", "user");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                                          payload.User

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payload.User = __value, payload.User))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => payload.User));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label for=\"ttype\">Transaction Type</label>\n        ");
                __Blazor.CP380_B3_BlockBlazor.Pages.Payloads.TypeInference.CreateInputSelect_0(__builder2, 41, 42, "ttype", 43, 
#nullable restore
#line 53 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                                             payload.TransactionType

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payload.TransactionType = __value, payload.TransactionType)), 45, () => payload.TransactionType, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "<option value=\"BUY\">Buy</option>\n            ");
                    __builder3.AddMarkupContent(48, "<option value=\"SELL\">Sell</option>\n            ");
                    __builder3.AddMarkupContent(49, "<option value=\"GRANT\">Grant</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "<label for=\"item\">Item</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "id", "item");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                                          payload.Item

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payload.Item = __value, payload.Item))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => payload.Item));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "<label for=\"amount\">Amount</label>\n        ");
                __Blazor.CP380_B3_BlockBlazor.Pages.Payloads.TypeInference.CreateInputNumber_1(__builder2, 64, 65, "amount", 66, "form-control", 67, 
#nullable restore
#line 65 "C:\Users\vinay\OneDrive\Pictures\Part 3\CP380-B3-BlockBlazor\Pages\Payloads.razor"
                                              payload.Amount

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payload.Amount = __value, payload.Amount)), 69, () => payload.Amount);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.AddMarkupContent(71, "<button type=\"submit\" class=\"btn btn-primary\">Add Payload</button>");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.CP380_B3_BlockBlazor.Pages.Payloads
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
