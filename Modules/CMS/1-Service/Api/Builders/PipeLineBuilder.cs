using Api.Configurations;
using MediatR;

namespace Api.Builders
{
    public static class PipeLineBuilder
    {
        public static WebApplication ConfigurePipeLines(this WebApplication app)
        {
            // .NET Native DI Abstraction

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseSwaggerSetup();

            return app;
        }
    }
}
