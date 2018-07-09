namespace TestAgioGlobalRepository.IoC
{
    using Autofac;
    using Airports;
    public class RepositoryModule : Module
    {
            protected override void Load(ContainerBuilder builder)
            {
            builder.RegisterType<AirportRepository>()
                .As<IAirportRepository>()
                .InstancePerLifetimeScope();
        }
        }
    
}
