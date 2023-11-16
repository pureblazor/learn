using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PureBlazor.Learn.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddHttpClient<YourApiClient>(static client =>
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
});

await builder.Build().RunAsync();
