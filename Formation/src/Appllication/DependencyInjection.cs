using Appllication.Commons.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Appllication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var ass = Assembly.GetExecutingAssembly();

            services.AddMediatR(c => {
                c.RegisterServicesFromAssembly(ass);

                c.AddBehavior(typeof(IPipelineBehavior<,>),
                    typeof(UnhandledExceptionBehavior<,>));

                c.AddBehavior(typeof(IPipelineBehavior<,>),
                    typeof(ValidationBehavior<,>));
            });

            services.AddValidatorsFromAssembly(ass);
            return services;
        }
    }
}
