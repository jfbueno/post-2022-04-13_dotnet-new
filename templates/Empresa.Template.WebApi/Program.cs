using Empresa.Template.WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDomainServices()
    .AddServicesWithParam(ParamDoServico);

var app = builder.Build();

if (Convert.ToBoolean(app.Configuration["EnableSwagger"]))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors()
    .UseHsts()
    .UseAuthentication()
    .UseAuthorization()
    .UseForwardedHeaders();

app.MapControllers();

app.Run();