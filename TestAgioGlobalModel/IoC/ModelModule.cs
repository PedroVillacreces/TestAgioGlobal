namespace TestAgioGlobalModel.IoC
{
    using Autofac;
    public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ModelContext>()
                .InstancePerLifetimeScope();
        }
    }
}
