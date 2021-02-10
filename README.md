# FromMVCToBlazor
Demo for converting MVC to Blazor

## Starting setup
- MVC installed

## Steps
1. Create Blazor project
2. Add Blazor project to server dependency
3. Remove wwwroot/index.html
4. Remove from Program.Main: builder.RootComponents.Add<App>("#app");
5. Change in startup of the server:
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

6. On the page you want the component added
```
<component type="typeof({component})" render-mode="WebAssemblyPrerendered" />

@section Scripts {
<script src="_framework/blazor.webassembly.js"></script>
}
```
