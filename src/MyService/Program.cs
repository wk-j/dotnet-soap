using Models;
using Server;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Soap
builder.Services.AddSoapCore();
builder.Services.AddSingleton<ISampleService, SampleService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Soap
app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.UseSoapEndpoint<ISampleService>("/Service.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<ISampleService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
