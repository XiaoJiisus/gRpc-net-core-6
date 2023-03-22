var builder = WebApplication.CreateBuilder(args);

//Services configuration
services.AddControllers();
services.AddSingleton<ISingletonService, SingletonService>();
services.AddScopped<IScopedService, ScopedService>();
services.AddTransient<ITransientService, TransientService>();

var app = builder.Build();

//Services activation
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirecion();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.Run();