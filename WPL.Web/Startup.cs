using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WPL.Application.Services;
using WPL.Data.Context;
using WPL.Data.Repositories;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<WPLContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("MySqlConnectionString")
                )
                .UseLazyLoadingProxies()
            );

            services.AddScoped(typeof(ICampeonatoAppService), typeof(CampeonatoAppService));
            services.AddScoped(typeof(ICampeonatoEdicaoAppService), typeof(CampeonatoEdicaoAppService));

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(ICampeonatoEdicaoFaseRepository), typeof(CampeonatoEdicaoFaseRepository));
            services.AddScoped(typeof(ICampeonatoEdicaoRepository), typeof(CampeonatoEdicaoRepository));
            services.AddScoped(typeof(ICampeonatoEdicaoTimeRepository), typeof(CampeonatoEdicaoTimeRepository));
            services.AddScoped(typeof(ICampeonatoRepository), typeof(CampeonatoRepository));
            services.AddScoped(typeof(IJogadorRepository), typeof(JogadorRepository));
            services.AddScoped(typeof(IJogadorSenhaRepository), typeof(JogadorSenhaRepository));
            services.AddScoped(typeof(IJogadorStatusHistoricoRepository), typeof(JogadorStatusHistoricoRepository));
            services.AddScoped(typeof(IJogoJogadorRepository), typeof(JogoJogadorRepository));
            services.AddScoped(typeof(IJogoRepository), typeof(JogoRepository));
            services.AddScoped(typeof(IJogoTimeRepository), typeof(JogoTimeRepository));
            services.AddScoped(typeof(IPlataformaRepository), typeof(PlataformaRepository));
            services.AddScoped(typeof(IPosicaoRepository), typeof(PosicaoRepository));
            services.AddScoped(typeof(ITimeJogadorRepository), typeof(TimeJogadorRepository));
            services.AddScoped(typeof(ITimeRepository), typeof(TimeRepository));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
