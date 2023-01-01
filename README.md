![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/gusroitman/Blazor_Json?logoColor=red)
![.Net](https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white)
![Blazor](https://img.shields.io/badge/blazor-%235C2D91.svg?logo=blazor&logoColor=white)
### Hello! I´m Gustavo :wave: 

### I made an example for reading and writing to/from a json file in Blazor Server


```
For Blazor Wasm use instead :
protected override async Task OnInitializedAsync()
    {
        provinces = await httpClient.GetFromJsonAsync<List<Provinces>>("provinces.json");
    }
```
For more information about these methods please consult :
* [Call a web API from ASP.NET Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/call-web-api?view=aspnetcore-7.0&pivots=webassembly)

---
#### You need to install MudBlazor Nuget Package.
#### Find the package through NuGet Package Manager or install it with following command.
```
dotnet add package MudBlazor
```

#### Add the following to your HTML head section, it's either index.html or _Layout.cshtml/_Host.cshtml depending on whether you're running WebAssembly or Server.
```
<link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet" />
<link href="_content/MudBlazor/MudBlazor.min.css" rel="stylesheet" />
```

#### Then open Pages \_Layout.cshtml (Blazor Server .NET 6), Pages\_Host.cshtml (Blazor Server .NET 7) or wwwroot/index.html (Blazor WebAssembly) and include this snippet :
```
    <script src="_content/MudBlazor/MudBlazor.min.js"></script>
```

#### You can also include globally in your _Imports.razor file of your Blazor application and import the namespaces :
```
@using Mudblazor
@using Mudblazor.Services
```

#### Finally you can add the services to your program.cs like this :

```
builder.Services.AddMudServices();
```

___
#### Screenshot :

![This is an image](https://github.com/gusroitman/Blazor-Charts-Examples/blob/master/Charts_MudBlazor/wwwroot/images/chartsample1.png)

---
If you have any questions feel free to ask. :right_anger_bubble:
