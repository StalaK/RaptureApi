using Rapture.Api;
using Rapture.Repository;
using Rapture.Service;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<RaptureContext>();
builder.Services.AddScoped<RaptureContext>(_ => new RaptureContext());

builder.Services.AddScoped<IRaptureRepository, RaptureRepository>();
builder.Services.AddScoped<IRaptureService, RaptureService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new() { Title = "Rapture.Api", Version = "v1" }));

builder.Services.AddCors(options =>
    options.AddPolicy("joshh", policy => policy.WithOrigins("https://www.joshh.co.uk/")));

builder.Services.AddRateLimiter(options =>
{
    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
        RateLimitPartition.GetFixedWindowLimiter(
            context.Request.Host.ToString(),
            _ => new FixedWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 60,
                QueueLimit = 0,
                Window = TimeSpan.FromHours(1)
            }));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rapture.Api v1"));

app.LoadEndpoints();

app.Run();
