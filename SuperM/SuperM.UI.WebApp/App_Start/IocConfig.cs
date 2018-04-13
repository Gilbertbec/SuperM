namespace SuperM.UI.WebApp.App_Start
{
	using Autofac;
	using Autofac.Integration.Mvc;
	using System.Reflection;
	using System.Web.Mvc;

	public class IocConfig
	{
		public static Autofac.IContainer Container { get; set; }

		public static void Setup()
		{
			Container = GetContainerBuilder().Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
		}

		private static ContainerBuilder GetContainerBuilder()
		{
			var builder = new ContainerBuilder();
			builder.RegisterAssemblyTypes(Assembly.Load("SuperM.Data.Repositories")).PropertiesAutowired();
			builder.RegisterAssemblyTypes(Assembly.Load("SuperM.Business.Services")).PropertiesAutowired();
			builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
			return builder;
		}
	}
}
