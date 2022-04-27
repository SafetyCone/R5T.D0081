using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0081.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedExecutionSynchronicityProvider : IExecutionSynchronicityProvider, IServiceImplementation
    {
        private Synchronicity Synchronicity { get; }


        public ConstructorBasedExecutionSynchronicityProvider(
            [NotServiceComponent] Synchronicity synchronicity)
        {
            this.Synchronicity = synchronicity;
        }

        public Task<Synchronicity> GetExecutionSynchronicity()
        {
            return Task.FromResult(this.Synchronicity);
        }
    }
}
