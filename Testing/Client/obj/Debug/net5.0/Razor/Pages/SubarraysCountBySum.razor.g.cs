#pragma checksum "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2af7dabc0791aeed6c702ea6ae7f92a20fa1c9"
// <auto-generated/>
#pragma warning disable 1591
namespace Testing.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Testing.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Testing.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Blazor\Testing\Testing\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
using Testing.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/subarraysCountBySum")]
    public partial class SubarraysCountBySum : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SubarraysCountBySum</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "control-section col-lg-12");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content wrapper");
#nullable restore
#line 10 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
         if (string.IsNullOrEmpty(Message))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                              subarray

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                                                         OnInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "textbox");
                __builder2.AddMarkupContent(16, "<label for=\"arr\" style=\"padding: 20px 0 5px 0\">arr</label>\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(17);
                __builder2.AddAttribute(18, "id", "textbox");
                __builder2.AddAttribute(19, "Placeholder", "ingresa un array de ints");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                              subarray.arr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subarray.arr = __value, subarray.arr))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => subarray.arr));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "textbox");
                __builder2.AddMarkupContent(26, "<label for=\"k\" style=\"padding: 20px 0 5px 0\">k</label>\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(27);
                __builder2.AddAttribute(28, "id", "textbox");
                __builder2.AddAttribute(29, "Placeholder", "Ingresa un int positivo");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                              subarray.k

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subarray.k = __value, subarray.k))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => subarray.k));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "multilinetextbox");
                __builder2.AddMarkupContent(36, "<label for=\"s\" style=\"padding: 10px 0 5px 0\">s</label>\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(37);
                __builder2.AddAttribute(38, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Placeholder", "ingresa un long");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                 subarray.s

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subarray.s = __value, subarray.s))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => subarray.s));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __Blazor.Testing.Client.Pages.SubarraysCountBySum.TypeInference.CreateValidationMessage_0(__builder2, 44, 45, 
#nullable restore
#line 26 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                  () => subarray.s

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "sfButton");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(49);
                __builder2.AddAttribute(50, "type", "submit");
                __builder2.AddAttribute(51, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Submit");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "alert alert-success");
            __builder.AddContent(56, 
#nullable restore
#line 37 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Blazor\Testing\Testing\Client\Pages\SubarraysCountBySum.razor"
       

    private int[] arr;
    private int k;
    private long s;
    private int n;

    private string Message = string.Empty;
    private SubarrayForm subarray = new SubarrayForm();
    private void OnValidSubmit()
    {
        arr = Array.ConvertAll(subarray.arr.ToCharArray(), c => (int)Char.GetNumericValue(c));
        k = int.Parse(subarray.k);
        s = long.Parse(subarray.s);
        subarraysCountBySum();
        StateHasChanged();
    }

    private void subarraysCountBySum()
    {
        List<int> a = new List<int>();
        int j = 0;
        while(k + j < arr.Length)
        {
            for (int i = 0; i < k + j; i++)
            {
                a.Add(arr[i]);
                if (a.Sum() == s)
                {
                    n++;
                    a.Clear();
                    break;
                }
            }
        }
    }

    private void OnInvalidSubmit()
    {
        Message = string.Empty;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Testing.Client.Pages.SubarraysCountBySum
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591