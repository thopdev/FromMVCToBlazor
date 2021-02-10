# FromMVCToBlazor
Demo for converting MVC to Blazor

## Starting setup
- MVC installed or [Start setup](https://github.com/thopdev/FromMVCToBlazor/tree/0-project_start)

## Steps
1. Create Blazor project
2. Add Blazor project to Server dependency
3. Add package to Server:     `<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.Server" Version="5.0.3" />` 
3. Remove wwwroot/index.html from the Blazor project
4. Remove from Blazor Program.Main: builder.RootComponents.Add<App>("#app");
5. Change in startup of the Server:
  - Replace 
  ``` 
   if (env.IsDevelopment())
      {
          app.UseDeveloperExceptionPage();
      }
  ```
  With 
  ```
   if (env.IsDevelopment())
      {
          app.UseDeveloperExceptionPage();
          app.UseWebAssemblyDebugging();
      }
  ```
  - Add app.UseBlazorFrameworkFiles();

6. On the page you want the component added (on the server)
```
<component type="typeof({component})" render-mode="WebAssemblyPrerendered" />

@section Scripts {
<script src="_framework/blazor.webassembly.js"></script>
}
```
