#pragma checksum "C:\Work\projects\Pomodoro\Pomodoro\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae2185530dd07a391651ddf0d693531944b2f8f"
// <auto-generated/>
#pragma warning disable 1591
namespace Pomodoro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Pomodoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\projects\Pomodoro\Pomodoro\_Imports.razor"
using Pomodoro.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""row justify-content-center align-items-center h-100"">
        <div class=""jumbotron col-4 px-4"">
            <div class=""container-fluid"">
                <div class=""row timer justify-content-center"">
                    <div class=""minutes"">25</div>
                    <div class=""colon"">:</div>
                    <div class=""seconds"">00</div>
                </div>
                <div class=""row timer intermission"">
                    <div class=""col-6"">Следующий перерыв</div>
                    <div class=""col-3""><strong>5</strong> минут</div>
                </div>
                <div class=""row justify-content-around"">
                    <button class=""btn btn-lg btn-success"">Запуск</button>
                    <button class=""btn btn-lg btn-danger"">Стоп</button>
                </div>
            </div>
        </div>
    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
