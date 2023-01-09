using Api.Builders;
using Api.Configurations;
using Application.CustomerService.Command;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



var app = builder.ConfigureServices().ConfigurePipeLines();

app.Run();
