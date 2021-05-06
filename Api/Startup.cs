using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Data.Interfaces;
using Data.Repos;
using Data.EFModels;
using Domain.Models;
using Core.Interfaces;
using Core.Services;

namespace Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<BankAppDataContext>();

            services.AddScoped<ICustomerRepo, CustomerRepo>();
            services.AddScoped<ICrudRepo<Account>, CrudRepo<Account>>();
            services.AddScoped<ICrudRepo<AccountType>, CrudRepo<AccountType>>();
            services.AddScoped<ICrudRepo<Transaction>, CrudRepo<Transaction>>();
            services.AddScoped<ICrudRepo<Loan>, CrudRepo<Loan>>();
            services.AddScoped<ICrudRepo<Card>, CrudRepo<Card>>();

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICrudService<Account>, CrudService<Account>>();
            services.AddScoped<ICrudService<AccountType>, CrudService<AccountType>>();
            services.AddScoped<ICrudService<Transaction>, CrudService<Transaction>>();
            services.AddScoped<ICrudService<Loan>, CrudService<Loan>>();
            services.AddScoped<ICrudService<Card>, CrudService<Card>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
