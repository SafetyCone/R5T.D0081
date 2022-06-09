using System;

using R5T.Magyar;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0081.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedExecutionSynchronicityProvider"/> implementation of <see cref="IExecutionSynchronicityProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExecutionSynchronicityProvider> AddConstructorBasedExecutionSynchronicityProviderAction(this IServiceAction _,
            Synchronicity synchronicity)
        {
            var output = _.New<IExecutionSynchronicityProvider>(services => services.AddConstructorBasedExecutionSynchronicityProvider(
                synchronicity));

            return output;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedSynchronousExecutionSynchronicityProvider"/> implementation of <see cref="IExecutionSynchronicityProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExecutionSynchronicityProvider> AddHardCodedSynchronousExecutionSynchronicityProviderAction(this IServiceAction _)
        {
            var output = _.New<IExecutionSynchronicityProvider>(services => services.AddHardCodedSynchronousExecutionSynchronicityProvider());
            return output;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedAsynchronousExecutionSynchronicityProvider"/> implementation of <see cref="IExecutionSynchronicityProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExecutionSynchronicityProvider> AddHardCodedAsynchronousExecutionSynchronicityProviderAction(this IServiceAction _)
        {
            var output = _.New<IExecutionSynchronicityProvider>(services => services.AddHardCodedAsynchronousExecutionSynchronicityProvider());
            return output;
        }
    }
}
