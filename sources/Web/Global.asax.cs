namespace DotNetConf.Sphinx.Web
{
    using System.Web.Mvc;
    using Infrastructure.BootstrapperTasks;
    using MvcExtensions;
    using MvcExtensions.Windsor;

    public class MvcApplication : WindsorMvcApplication
    {
        public MvcApplication()
        {
            Bootstrapper.BootstrapperTasks
                .Include<RegisterRoutes>()
                .Include<RegisterControllers>()
                .Include<RegisterModelMetadata>();
        }

        protected override void OnStart()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
        }
    }
}