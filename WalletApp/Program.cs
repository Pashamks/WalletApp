using EFCoreRepository;
using Microsoft.OpenApi.Models;
using WalletApp.Middleware;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Wallet App RestApi", Version = "v1" });
});
builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.AddLogging();

builder.Services.AddSingleton(new EFCoreDbContext(builder.Configuration.GetConnectionString("Development")));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); // for solving problem with time zore

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();


app.Run();
