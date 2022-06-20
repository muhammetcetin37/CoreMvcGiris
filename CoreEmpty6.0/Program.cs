var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();



app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    // www.test.com.tr => Domain
    // www.test.com.tr/Musteriler => Domain/Controller demek oluyor
    //www.test.com.tr/Musteriler/Index => Domain/Controller/Action

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
