using System;


using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AFL.OTDR.Service.GraphQL;
using AFL.OTDR.Service.GraphQL.InternalOTDR;
using AutoMapper;


namespace AFL.OTDR.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add
        // services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(
                builder => builder.AddConsole());

            
            services.AddControllers();
            services.AddHealthChecks();

            services.AddSingleton<ILogger>(
                loggerFactory.CreateLogger("Server"));

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });

            services.AddSingleton<IMapper>(AutoMapperUtility.CreateMapperConfig().CreateMapper());

            InternalOTDRSchemaFactory.AddInternalOTDRGraphQL(services, "./GraphQL/OTDR/InternalGraphQL/internalOTDRSchema.gql");
        }

        // This method gets called by the runtime. Use this method to
        // configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseHealthChecks("/healthy");
            app.UseHealthChecks("/ready");

            app.UseAuthorization();

            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = "/ui/playground"
            });

            
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();

                // This is an endpoint for the internal GraphQL
                // server in OTDR-MS
                // This endpoint will be used only by Project-MS
                // and will not be exposed externally

                endpoints.MapGraphQL("internal/otdr-graphql", "InternalOtdrGraphQL");

                endpoints.MapControllers();
            });
        }
    }
}