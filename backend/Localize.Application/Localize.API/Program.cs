using Localize.CrossCutting.DI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.AddDependencyInjection();

builder.AddSwaggerDependencyInjection();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseCors("CorsPolicy");

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
