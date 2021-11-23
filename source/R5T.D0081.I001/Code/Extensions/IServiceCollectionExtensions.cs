using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Magyar;


namespace R5T.D0081.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedExecutionSynchronicityProvider"/> implementation of <see cref="IExecutionSynchronicityProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedExecutionSynchronicityProvider(this IServiceCollection services, 
            Synchronicity synchronicity)
        {
            services.AddSingleton<IExecutionSynchronicityProvider>(sp => new ConstructorBasedExecutionSynchronicityProvider(
                synchronicity));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedSynchronousExecutionSynchronicityProvider"/> implementation of <see cref="IExecutionSynchronicityProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedSynchronousExecutionSynchronicityProvider(this IServiceCollection services)
        {
            services.AddSingleton<IExecutionSynchronicityProvider, HardCodedSynchronousExecutionSynchronicityProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedAsynchronousExecutionSynchronicityProvider"/> implementation of <see cref="IExecutionSynchronicityProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedAsynchronousExecutionSynchronicityProvider(this IServiceCollection services)
        {
            services.AddSingleton<IExecutionSynchronicityProvider, HardCodedAsynchronousExecutionSynchronicityProvider>();

            return services;
        }
    }
}
