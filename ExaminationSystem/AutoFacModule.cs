using Autofac;
using ExaminationSystem.Data;
using ExaminationSystem.Repository;
using ExaminationSystem.Services.Courses;
namespace ExaminationSystem
{
    public class AutoFacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Context>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ICourseService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
