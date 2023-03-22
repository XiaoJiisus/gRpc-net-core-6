var builder = WebApplication.CreateBuilder(args);

//Services configuration
services.AddControllers();
builder.Services.Configure<SmtpConfiguration>(builder.Configuration.GetSection("SmtpConfiguration"));//Options pattern is simplest way

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