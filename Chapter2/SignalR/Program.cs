using SignalRDemo.Hubs;

#region Services_Configuration

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

#endregion

var app = builder.Build();

#region Services_Activation

app.MapHub<MyHub>("/myhub");
app.MapGet("/", () => "Hello World!");

#endregion

app.Run();
