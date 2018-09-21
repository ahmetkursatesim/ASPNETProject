using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using System.Linq;
using Abp.AutoMapper;
using AutoMapper;
using Myproject.Book;
using Myproject.Books.DTO;
using Myproject.Authors;
using Myproject.Authors.DTO;
using Swashbuckle.Application;

namespace Myproject.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MyprojectApplicationModule))]
    public class MyprojectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MyprojectApplicationModule).Assembly, "app")
                .Build();
            Configuration.Modules.AbpWebApi().HttpConfiguration
            .EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Myproject.WebApi");
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            })
            .EnableSwaggerUi(c =>
            {
                c.InjectJavaScript(Assembly.GetAssembly(typeof(MyprojectApplicationModule)), "Myproject.WebApi.Api.Scripts.Swagger-Custom.js");
            });


        }
      
    }
}
