using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using RaisingIt.RecruitmentTest.Domain.Campaigns;

namespace RaisingIt.RecruitmentTest.Web.App_Start
{
    public class IocConfig
    {
        public static void RegisterIoc()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterType<CampaignClient>().As<ICampaignClient>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}