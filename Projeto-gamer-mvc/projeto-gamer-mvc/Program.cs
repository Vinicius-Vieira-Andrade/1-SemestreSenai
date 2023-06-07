var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



////configuração da sessão baseado na documentação de sessão da ms
builder.Services.AddDistributedMemoryCache(); 

builder.Services.AddSession(options =>
{
    //tempo de duração da sessão
    options.IdleTimeout = TimeSpan.FromHours(1); //sessão ficará ativa por 1 hora, mantém os dados do usuario por 1 hora
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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

app.UseRouting();

app.UseAuthorization();


//use session
app.UseSession(); //usar a sessão

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
