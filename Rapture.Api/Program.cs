using Rapture.Common.Mapper;
using Rapture.Repository;
using Rapture.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<RaptureContext>();
builder.Services.AddScoped<RaptureContext>(_ => new RaptureContext());

builder.Services.AddScoped<IRaptureRepository, RaptureRepository>();
builder.Services.AddScoped<IRaptureService, RaptureService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Rapture.Api", Version = "v1" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rapture.Api v1"));
}

// Endpoints
app.MapGet("/GetAllRaptures", async (IRaptureService service) => 
    RaptureToRaptureDetailsViewModel.Map(await service.GetAllRaptures()));

app.MapGet("/GetSurvivedRaptures", async (IRaptureService service, DateTime dateOfBirth) => 
    RaptureToRaptureDetailsViewModel.Map(await service.GetSurvivedRaptures(dateOfBirth)));

app.MapGet("/GetNextRapture", async (IRaptureService service) => 
    RaptureToRaptureDetailsViewModel.Map(await service.GetNextRapture()));

app.MapGet("/GetCurrentRapture", async (IRaptureService service) => 
    RaptureToRaptureDetailsViewModel.Map(await service.GetCurrentRapture()));

app.MapGet("/GetAllFutureRaptures", async (IRaptureService service) => 
    RaptureToRaptureDetailsViewModel.Map(await service.GetAllFutureRaptures()));

app.Run();
