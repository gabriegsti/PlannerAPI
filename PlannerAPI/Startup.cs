using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PlannerAPI.Data;
using PlannerAPI.Facades;
using PlannerAPI.Facades.Facades;
using PlannerAPI.Facades.Interfaces;
using System;

namespace PlannerAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<PlannerContext>(options
                =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")).UseLowerCaseNamingConvention();
                
            });
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlannerAPI", Version = "v1" });
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IUsuarioFacade, UsuarioFacade>();
            services.AddTransient<IMateriaFacade, MateriaFacade>();
            services.AddTransient<IEventoFacade, EventoFacade>();
            services.AddTransient<IAvaliacaoFacade, AvaliacaoFacade>();
            services.AddTransient<IAulaFacade, AulaFacade>();
            services.AddTransient<IAnotacaoFacade, AnotacaoFacade>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlannerAPI v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
