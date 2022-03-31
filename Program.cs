var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

if (!app.Environment.IsDevelopment()) 
	app.UseSpaStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.UseSpa(spa =>
{
	// To learn more about options for serving an Angular SPA from ASP.NET Core,
    // see https://go.microsoft.com/fwlink/?linkid=864501

    spa.Options.SourcePath = "wwwroot";
});

app.Run();
