using Refit;
using ViaCep_Api.Integracao;
using ViaCep_Api.Integracao.Interfaces;
using ViaCep_Api.Integracao.Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adicione seus serviços aqui, antes de `builder.Build()`
builder.Services.AddScoped<IViaCepIntegracao, ViaCepIntegracao>();

builder.Services.AddRefitClient<IViaCep>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://viacep.com.br/");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
