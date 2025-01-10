using ChatRoomDemo.Hubs;

var builder = WebApplication.CreateBuilder(args);

// 1. Add services
builder.Services.AddRazorPages(); // or AddControllersWithViews()
builder.Services.AddSignalR();    // <-- Add SignalR

var app = builder.Build();

// 2. Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // app.UseHsts();
}

app.UseStaticFiles();  // needed if you host JS files
app.UseRouting();

// 3. Map your Razor pages or controllers
app.MapRazorPages(); // or app.MapControllerRoute()

// 4. Map your Hub
app.MapHub<ChatHub>("/chatHub");

app.Run();
