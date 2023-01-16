using Api.Configurations;
using MediatR;

namespace Api.Builders
{
    public static class PipeLineBuilder
    {
        public static WebApplication ConfigurePipeLines(this WebApplication app)
        {
            //Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseSwaggerSetup();

            return app;
        }
    }
}
