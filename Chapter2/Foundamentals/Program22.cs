var builder = WebApplication.CreateBuilder(args);

//Services configuration
/*
    Includes thet ype of application, third-party libraries, authentication, authorization, and
    the registration of services with dependency injection
    - is implemented at the beginning of the file, before building the app with the builder.Build() method
*/
builder.Services.AddRazorPages();
var app = builder.Build();


//Services activation
/*
    Defines the Asp.Net Core middleware pipeline. Middleware is a component that, once assembled
    (in a particular order) into an application, can handle request and responses and perform
    operations before and after the next component
    - occurs after the builder.Build() method but before the app.Run() method
*/
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