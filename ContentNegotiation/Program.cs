var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlSerializerFormatters();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();