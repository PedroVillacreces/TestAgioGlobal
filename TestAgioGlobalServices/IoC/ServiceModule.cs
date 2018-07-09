namespace TestAgioGlobalServices.IoC
{
    using Autofac;

    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AirportService>()
                .As<IAirportService>()
                .InstancePerLifetimeScope();
        }
    }
}
