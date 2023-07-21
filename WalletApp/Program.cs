using AutoMapper;
using EFCoreRepository;
using EFCoreRepository.Interfaces;
using EFCoreRepository.Repository;
using Microsoft.OpenApi.Models;
using WalletApp.Middleware;
using WalletBusinessLogic.Interfaces;
using WalletBusinessLogic.Managers;
using WalletBusinessLogic.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Wallet App RestApi", Version = "v1" });
});
builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.AddLogging();

builder.Services.AddSingleton(new EFCoreDbContext(builder.Configuration.GetConnectionString("Development")));
builder.Services.AddSingleton<ITransactionRepository, TransactionRepository>();
builder.Services.AddSingleton<ITransactionManager, TransactionManager>();
builder.Services.AddSingleton<IPointManager, PointManager>();
builder.Services.AddSingleton<IUserManager, UserManager>();

var mapConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile<MappingProfile>();
    mc.ShouldMapMethod = (m => false);
});
IMapper mapper = new Mapper(mapConfig);
builder.Services.AddSingleton(mapper);

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
